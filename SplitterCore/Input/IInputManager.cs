namespace SplitterCore.Input
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel; // <-- Add this using statement

    public interface IInputManager
    {
        event EventHandler<InputEventArgs> InputActivity;

        event EventHandler<InputDeviceChangedEventArgs> InputDeviceChanged;

        event EventHandler EmergencyLeft;

        event EventHandler EmergencyRight;

        event EventHandler EmergencyStop;

        List<Keyboard> Keyboards { get; set; }

        List<Mouse> Mice { get; set; }

        // The following two lines have been REMOVED:
        // string InputMonitorHistory { get; set; }
        // void ClearInputMonitorHistory();

        // The following two lines have been ADDED:
        bool IsInputMonitorActive { get; set; }

        ObservableCollection<string> InputMonitorLog { get; }

        bool IsKeyDown(InputDevice inputDevice, InputKey key);

        void Destroy();
    }
}