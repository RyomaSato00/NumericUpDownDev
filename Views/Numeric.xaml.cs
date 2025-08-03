using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumericUpDownDev.Views;

/// <summary>
/// Interaction logic for Numeric.xaml
/// </summary>
public partial class Numeric : UserControl
{
    private const double MOUSE_WHEEL_DELTA_PER_NOTCH = 120.0;

    public static readonly DependencyProperty MaximumProperty =
    DependencyProperty.Register(nameof(Maximum), typeof(double), typeof(Numeric), new PropertyMetadata(double.MaxValue));

    public static readonly DependencyProperty MinimumProperty =
    DependencyProperty.Register(nameof(Minimum), typeof(double), typeof(Numeric), new PropertyMetadata(double.MinValue));

    public static readonly DependencyProperty ValueProperty =
    DependencyProperty.Register(nameof(Value), typeof(double), typeof(Numeric), new PropertyMetadata(0.0));

    public static readonly DependencyProperty IntervalProperty =
    DependencyProperty.Register(nameof(Interval), typeof(double), typeof(Numeric), new PropertyMetadata(1.0));

    public double Maximum
    {
        get => (double)GetValue(MaximumProperty);
        set => SetValue(MaximumProperty, value);
    }

    public double Minimum
    {
        get => (double)GetValue(MinimumProperty);
        set => SetValue(MinimumProperty, value);
    }

    public double Value
    {
        get => (double)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    public double Interval
    {
        get => (double)GetValue(IntervalProperty);
        set => SetValue(IntervalProperty, value);
    }

    public Numeric()
    {
        InitializeComponent();
    }

    private void UpButton_Click(object sender, RoutedEventArgs e)
    {
        if (Value + Interval <= Maximum)
        {
            Value += Interval;
        }
    }

    private void DownButton_Click(object sender, RoutedEventArgs e)
    {
        if (Value - Interval >= Minimum)
        {
            Value -= Interval;
        }
    }

    private void IndicatorFrameBorder_MouseWheel(object sender, MouseWheelEventArgs e)
    {
        if (MOUSE_WHEEL_DELTA_PER_NOTCH <= e.Delta)
        {
            if (Value + Interval <= Maximum)
            {
                Value += Interval;
            }
        }
        else if (-MOUSE_WHEEL_DELTA_PER_NOTCH >= e.Delta)
        {
            if (Value - Interval >= Minimum)
            {
                Value -= Interval;
            }
        }
        e.Handled = true;
    }
}

