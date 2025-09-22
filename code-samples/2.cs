using Microsoft.UI.Xaml;

using System.Diagnostics;

namespace App3;

public sealed partial class ControlWindow : Window
{
    public ControlWindow()
    {
        InitializeComponent();
        control.AccessKeyDisplayDismissed += (s, e) => 
        {
            Debug.WriteLine("AccessKeyDisplayDismissed");
        };

        control.AccessKeyDisplayRequested += (s, e) => 
        {
            Debug.WriteLine("AccessKeyDisplayRequested");
        };

        control.AccessKeyInvoked += (s, e) => 
        {
            Debug.WriteLine("AccessKeyInvoked");
        };

        control.ActualThemeChanged += (s, e) => 
        {
            Debug.WriteLine("ActualThemeChanged");
        };

        control.BringIntoViewRequested += (s, e) => 
        {
            Debug.WriteLine("BringIntoViewRequested");
        };

        control.CharacterReceived += (s, e) => 
        {
            Debug.WriteLine("CharacterReceived");
        };

        control.ContextCanceled += (s, e) => 
        {
            Debug.WriteLine("ContextCanceled");
        };

        control.ContextCanceled += (s, e) => 
        {
            Debug.WriteLine("ContextCanceled");
        };

        control.DataContextChanged += (s, e) => 
        {
            Debug.WriteLine("DataContextChanged");
        };

        control.DoubleTapped += (s, e) => 
        {
            Debug.WriteLine("DoubleTapped");
        };

        control.DragEnter += (s, e) => 
        {
            Debug.WriteLine("DragEnter");
        };

        control.DragLeave += (s, e) => 
        {
            Debug.WriteLine("DragLeave");
        };

        control.DragOver += (s, e) => 
        {
            Debug.WriteLine("DragOver");
        };

        control.DragStarting += (s, e) => 
        {
            Debug.WriteLine("DragStarting");
        };

        control.Drop += (s, e) => 
        {
            Debug.WriteLine("Drop");
        };

        control.DropCompleted += (s, e) => 
        {
            Debug.WriteLine("DropCompleted");
        };

        control.EffectiveViewportChanged += (s, e) => 
        {
            Debug.WriteLine("EffectiveViewportChanged");
        };

        control.FocusDisengaged += (s, e) =>
        {
            Debug.WriteLine("FocusDisengaged");
        };

        control.FocusEngaged += (s, e) =>
        {
            Debug.WriteLine("FocusEngaged");
        };

        control.IsEnabledChanged += (s, e) => 
        {
            Debug.WriteLine("IsEnabledChanged");
        };

        control.GettingFocus += (s, e) => 
        {
            Debug.WriteLine("GettingFocus");
        };

        control.GotFocus += (s, e) => 
        {
            Debug.WriteLine("GotFocus");
        };

        control.Holding += (s, e) => 
        {
            Debug.WriteLine("Holding");
        };

        control.KeyDown += (s, e) => 
        {
            Debug.WriteLine("KeyDown");
        };

        control.KeyUp += (s, e) => 
        {
            Debug.WriteLine("KeyUp");
        };

        control.LayoutUpdated += (s, e) => 
        {
            Debug.WriteLine("LayoutUpdated");
        };

        control.Loaded += (s, e) => 
        {
            Debug.WriteLine("Loaded");
        };

        control.Loading += (s, e) => 
        {
            Debug.WriteLine("Loading");
        };

        control.ManipulationCompleted += (s, e) => 
        {
            Debug.WriteLine("ManipulationCompleted");
        };

        control.ManipulationDelta += (s, e) => 
        {
            Debug.WriteLine("ManipulationDelta");
        };

        control.ManipulationInertiaStarting += (s, e) => 
        {
            Debug.WriteLine("ManipulationInertiaStarting");
        };

        control.ManipulationStarting += (s, e) => 
        {
            Debug.WriteLine("ManipulationStarting");
        };

        control.NoFocusCandidateFound += (s, e) => 
        {
            Debug.WriteLine("NoFocusCandidateFound");
        };

        control.PointerCanceled += (s, e) => 
        {
            Debug.WriteLine("PointerCanceled");
        };

        control.PointerCaptureLost += (s, e) => 
        {
            Debug.WriteLine("PointerCaptureLost");
        };

        control.PointerEntered += (s, e) => 
        {
            Debug.WriteLine("PointerEntered");
        };

        control.PointerExited += (s, e) => 
        {
            Debug.WriteLine("PointerExited");
        };

        control.PointerMoved += (s, e) => 
        {
            Debug.WriteLine("PointerMoved");
        };

        control.PointerReleased += (s, e) => 
        {
            Debug.WriteLine("PointerReleased");
        };

        control.PointerWheelChanged += (s, e) => 
        {
            Debug.WriteLine("PointerWheelChanged");
        };

        control.PreviewKeyDown += (s, e) => 
        {
            Debug.WriteLine("PreviewKeyDown");
        };

        control.PreviewKeyUp += (s, e) => 
        {
            Debug.WriteLine("PreviewKeyUp");
        };

        control.ProcessKeyboardAccelerators += (s, e) => 
        {
            Debug.WriteLine("ProcessKeyboardAccelerators");
        };

        control.RightTapped += (s, e) => 
        {
            Debug.WriteLine("RightTapped");
        };

        control.SizeChanged += (s, e) => 
        {
            Debug.WriteLine("SizeChanged");
        };

        control.Tapped += (s, e) => 
        {
            Debug.WriteLine("Tapped");
        };

        control.Unloaded += (s, e) => 
        {
            Debug.WriteLine("Unloaded");
        };

        Closed += (s, e) => 
        {
            Debug.WriteLine("\nWindow Closing\n");
        };
    }
}
