using System.Windows;
using System.Windows.Media.Imaging;
/// <summary>
/// Interface that needs to be implemented by
/// WPF application to supporting splash screen.
/// </summary>
public interface ISplashApplication
{
    /// <summary>
    /// Shows the splash screen
    /// </summary>
    void ShowSplash();

    /// <summary>
    /// Hides the splash screen
    /// </summary>
    void HideSplash();

    /// <summary>
    /// Adds the module image to the splash screen
    /// </summary>
    /// <param name="image"></param>
    void AddImage(BitmapImage image);

    /// <summary>
    /// Updates the message in splash screen
    /// </summary>
    /// <param name="message"></param>
    void UpdateSplashMessage(string message);

    /// <summary>
    /// Sets the MainWindow of the application
    /// </summary>
    /// <param name="shell"></param>
    void SetMainWindow(Window shell);
}