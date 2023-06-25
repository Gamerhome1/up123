﻿using UP.Commands;
using UP.Infrastructure;
using UP.Models;
using UP.Reports;
using UP.Reports.ExcelGenerators;
using UP.Types;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace UP.ViewModels
{
    public class LoadToFileViewModel
    {
        public LoadToFileViewModel()
        {
            Enrollees = DataBaseConnection.ApplicationContext.Enrollee.ToList();
            EnrolleeReport = new EnrolleeReport(Enrollees);
            ExcelGenerator = new ExcelGenerator();
            GoToWardPageCommand = new LambdaCommand(OnGoToWardPageCommandExecuted, CanGoToWardPageCommandExecute);
            LoadToExcelCommand = new LambdaCommand(OnLoadToExcelCommandexecuted, CanLoadToExcelCommandExecute);
        }

        public List<Enrollee> Enrollees { get; set; }

        public EnrolleeReport EnrolleeReport { get; set; }

        public ExcelGenerator ExcelGenerator { get; set; } 

        #region GoToWardPageCommand

        public ICommand GoToWardPageCommand { get; set; }

        public bool CanGoToWardPageCommandExecute(object parameter)
        {
            return true;
        }

        public void OnGoToWardPageCommandExecuted(object parameter)
        {
            MainViewModel.SwitchPage(MainPageType.WardPage);
        }

        #endregion

        #region LoadToExcelCommand 

        public ICommand LoadToExcelCommand { get; set; }

        private bool CanLoadToExcelCommandExecute(object parameter) 
        {
            return true;
        }

        private void OnLoadToExcelCommandexecuted(object parameter)
        {
            MessageBox.Show("Идёт выгрузка, пожалуйста подождите");
            var ExelReport = ExcelGenerator.Generate(EnrolleeReport);
            try
            {
                File.WriteAllBytes("../../../Reports/Files/Приёмная коммисия.xlsx", ExelReport);
            }
            catch
            {
                MessageBox.Show("Пожалуйста,закройте файл и повторите сохранение", "Ошибка!", MessageBoxButton.OK);
            }

            EnrolleeReport.Enrollees = new List<Enrollee>();
        }

        #endregion
    }
}