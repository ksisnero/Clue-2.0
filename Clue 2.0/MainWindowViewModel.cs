using Clue_2._0.ViewModels;
using DevExpress.Mvvm;

namespace Clue_2._0
{
    public class MainWindowViewModel : ViewModelBase
    {
        public virtual IntroWindowViewModel IntroWindow { get; set; }
        public virtual RoomWindowViewModel RoomWindow { get; set; }
        public virtual WeaponWindowViewModel WeaponWindow { get; set; }
        public virtual SuspectWindowViewModel SuspectWindow { get; set; }
        public virtual GameOverWindowViewModel GameOverWindow { get; set; }
        public virtual WindowOrganizer WindowSet { get; set; }

        public MainWindowViewModel()
        {
            IntroWindow = new IntroWindowViewModel();

            SuspectWindow = new SuspectWindowViewModel();

            WindowSet = WindowOrganizer.Create(IntroWindow);
        }
    }
}
