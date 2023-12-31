﻿using System;
using UP.Types;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using UP.Views.Windows.Main.Pages;

namespace UP.ViewModels
{
    public class MainViewModel
    {
        public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;

        private static Page selectedPage;
        private static RegistrationEnrollePage registrationEnrollePage;
        private static SelectCitizenshipPage selectCitizenshipPage;
        private static EducationPage educationPage;
        private static AvarageScoreSnilsPage avarageScoreSnilsPage;
        private static SpecialityPage specialityPage;
        private static DisabilityPage disabilityPage;
        private static GuardianPage guardianPage;
        private static LoadToFilePage loadToFilePage;
    
        public MainViewModel() 
        {
            SwitchPage(MainPageType.RegistrationEnrollePage);
        }

        public static Page SelectedPage
        {
            get { return selectedPage; }
            set { Set(ref selectedPage, value); }
        }

        public static void SwitchPage(MainPageType mainPageType)
        {
            switch (mainPageType)
            {
                case MainPageType.RegistrationEnrollePage:
                    if (registrationEnrollePage == null)
                    {
                        registrationEnrollePage = new RegistrationEnrollePage();
                    }
                    SelectedPage = registrationEnrollePage;
                    selectCitizenshipPage = null;
                    break;
                case MainPageType.SelectCitizenshipPage:
                    if (selectCitizenshipPage == null)
                    {
                        selectCitizenshipPage = new SelectCitizenshipPage();
                    }
                    SelectedPage = selectCitizenshipPage;
                    educationPage = null;
                    break;
                case MainPageType.EducationPage:
                    if (educationPage == null)
                    {
                        educationPage = new EducationPage();
                    }
                    SelectedPage = educationPage;
                    avarageScoreSnilsPage = null;
                    break;
                case MainPageType.CertificatePage:
                    if (avarageScoreSnilsPage == null)
                    {
                        avarageScoreSnilsPage = new AvarageScoreSnilsPage();
                    }
                    SelectedPage = avarageScoreSnilsPage;
                    specialityPage = null;
                    break;
                case MainPageType.SpecialityPage:
                    if (specialityPage == null)
                    {
                        specialityPage = new SpecialityPage();
                    }
                    SelectedPage = specialityPage;
                    disabilityPage = null;
                    break;
                case MainPageType.DisabilityPage:
                    if (disabilityPage == null)
                    {
                        disabilityPage = new DisabilityPage();
                    }
                    SelectedPage = disabilityPage;
                    guardianPage = null;
                    break;
                case MainPageType.WardPage:
                    if (guardianPage == null)
                    {
                        guardianPage = new GuardianPage();
                    }
                    SelectedPage = guardianPage;
                    loadToFilePage = null;
                    break;
                case MainPageType.LoadToFilePage:
                    if (loadToFilePage == null)
                    {
                        loadToFilePage = new LoadToFilePage();
                    }
                    SelectedPage = loadToFilePage;
                    break;
            }
        }

        public static void OnPropertyChanged([CallerMemberName] string propetyName = null) => StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(propetyName));

        public static bool Set<T>(ref T field, T value, [CallerMemberName] string propetyName = null)
        {
            if (Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propetyName);
            return true;
        }

    }
}
