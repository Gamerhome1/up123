﻿using UP.Commands;
using UP.Infrastructure;
using UP.Models;
using UP.Models.DTO;
using UP.Types;
using UP.Views.Windows.Education;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace UP.ViewModels
{
    public class EnrolleEducationViewModel
    {
        public EnrolleEducationViewModel()
        {
            Educations = new ObservableCollection<Education>(DataBaseConnection.ApplicationContext.Education);
            Enrollees = DataBaseConnection.ApplicationContext.Enrollee.ToList().ConvertAll(enrollee =>
            {
                return new EnrolleeDTO(enrollee.Id, enrollee.Name, enrollee.Surname,
                                       enrollee.Patronymic, enrollee.Gender, enrollee.DateOfBirth,
                                       enrollee.Snils, enrollee.YearOfAdmission, education: Educations.FirstOrDefault(education => education.Id == enrollee.EducationId));
            });
            GoToAvarageScoreSnilsPageCommand = new LambdaCommand(OnAvarageScoreSnilsPageCommandExecuted, CanGoToAvarageScoreSnilsPageCommandExecute);
            GoToPlaceOfResidencePageCommand = new LambdaCommand(OnGoToPlaceOfResidencePageCommandExecuted, CanGoToPlaceOfResidencePageExecute);
            OpenEducationWindowCommand = new LambdaCommand(OnOpenEducationWindowCommandExecuted, CanOpenEducationWindowCommandExecute);
            SaveCommand = new LambdaCommand(OnSaveCommandExecuted, CanSaveCommandExecute);
        }

        public List<EnrolleeDTO> Enrollees { get; set; }

        public ObservableCollection<Education> Educations { get; set; }

        public bool IsChanged { get; set; }

        #region OpenEducationWindowCommand

        public ICommand OpenEducationWindowCommand { get; set; }

        public bool CanOpenEducationWindowCommandExecute(object parameter)
        {
            return true;
        }

        public  void OnOpenEducationWindowCommandExecuted(object parameter)
        {
            EducationWindow educationWindow = new EducationWindow();
            educationWindow.ShowDialog();
            Educations.Clear();
            DataBaseConnection.ApplicationContext.Education.ToList().ForEach(Educations.Add);
            Enrollees.ForEach(enrollee =>
            {
                enrollee.Education = Educations.FirstOrDefault(education => education.Id == enrollee.EducationId);
            });
        }

        #endregion

        #region GoToAvarageScoreSnilsPageCommand

        public ICommand GoToAvarageScoreSnilsPageCommand { get; set; }

        public bool CanGoToAvarageScoreSnilsPageCommandExecute(object parameter)
        {
            return IsAllValid();
        }

        public void OnAvarageScoreSnilsPageCommandExecuted(object parameter)
        {
            MainViewModel.SwitchPage(MainPageType.CertificatePage);
        }

        #endregion

        #region GoToPlaceOfResidencePageCommand

        public ICommand GoToPlaceOfResidencePageCommand { get; set; }

        public bool CanGoToPlaceOfResidencePageExecute(object parameter)
        {
            return true;
        }

        public void OnGoToPlaceOfResidencePageCommandExecuted(object parameter)
        {
            MainViewModel.SwitchPage(MainPageType.SelectCitizenshipPage);
        }

        #endregion

        #region SaveCommand

        public ICommand SaveCommand { get; set; }

        public bool CanSaveCommandExecute(object parameter)
        {
            return IsAllValid() && !IsAllSaved();
        }

        public void OnSaveCommandExecuted(object parameter)
        {
            DbSet<Enrollee> dbEnrollees = DataBaseConnection.ApplicationContext.Enrollee;
            Enrollees.ToList().ForEach(enrollee =>
            {
                dbEnrollees.Find(enrollee.Id).Education = enrollee.Education;
            });
            DataBaseConnection.ApplicationContext.SaveChanges();
        }

        #endregion

        private bool IsAllSaved()
        {
            return IsChanged = CheckIsSaved();
        }

        private bool CheckIsSaved()
        {
            DbSet<Enrollee> dbEnrollees = DataBaseConnection.ApplicationContext.Enrollee;
            return Enrollees.All(enrollee =>
            {
                Enrollee dbEnrollee = dbEnrollees.Find(enrollee.Id);
                return enrollee.Education == dbEnrollee.Education;
            });
        }

        private bool IsAllValid()
        {
            return Enrollees.All(enrollee => enrollee.Education != null);
        }

    }
}
