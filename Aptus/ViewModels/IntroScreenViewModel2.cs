using Aptus.Models;
using Aptus;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Aptus.ViewModels
{
    public class IntroScreenViewModel2 : BaseViewModel2
    {
        private string _buttonText = "NEXT";
        public string ButtonText
        {
            get => _buttonText;
            set => SetProperty(ref _buttonText, value);
        }

        private int _position;
        public int Position
        {
            get => _position;
            set => SetProperty(ref _position, value, onChanged: (() =>
            {
                if (value == IntroScreens2.Count - 1)
                {
                    ButtonText = "NEXT";
                }
                else
                {
                    ButtonText = "CHOOSE";
                }
            }));
        }

        public ObservableCollection<IntroScreenModels2> IntroScreens2 { get; set; } = new ObservableCollection<IntroScreenModels2>();

        public IntroScreenViewModel2()
        {
            IntroScreens2.Add(new IntroScreenModels2
            {
                //IntroTitle = "Welcome To StudentApp",
                //IntroDescription = "Enjoy the captivating process of online education in a place and at a time of your choice",
                IntroImage = "femaleglutes",
            });

            IntroScreens2.Add(new IntroScreenModels2
            {
                //IntroTitle = "Anytime, Anywhere",
                //IntroDescription = "Now you can check homework anytime right from mobile",
                IntroImage = "femalequads",
            });

            IntroScreens2.Add(new IntroScreenModels2
            {
                //    IntroTitle = "Ready to Find A Course",
                //    IntroDescription = "Join our online school that will help you learn the cutting-edge skills to scale new heights in your creative career.",
                IntroImage = "femalehamstrings",
            });

            IntroScreens2.Add(new IntroScreenModels2
            {
                //IntroTitle = "Nesto Random",
                //IntroDescription = "Join our online school that will help you learn the cutting-edge skills to scale new heights in your creative career.",
                IntroImage = "femalearms",
            });
            IntroScreens2.Add(new IntroScreenModels2
            {
                //IntroTitle = "Nesto Random",
                //IntroDescription = "Join our online school that will help you learn the cutting-edge skills to scale new heights in your creative career.",
                IntroImage = "femaleback",
            });
        }

        public ICommand NextCommand => new Command(async () =>
        {
            if (Position >= IntroScreens2.Count - 1)
            {
                await AppShell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
            else
            {
                Position += 1;
            }
        });
    }
}
