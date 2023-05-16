
﻿using Pracownicy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pracownicy.Presenter
{
    internal class MainPresenter
    {

        private View.Form1 _view;
        private Model.MainModel _model;


        public MainPresenter (View.Form1 view, Model.MainModel model)
        {
            _view = view;
            _model = model;


            _view.AddButtonEvent += _view_AddButtonEvent;
            _view.SaveButtonEvent += _view_SaveButtonEvent;
            _view.LoadButtonEvent += _view_LoadButtonEvent;
            _view.EditButtonEvent += _view_EditButtonEvent;
            _view.ChangeButtonEvent += _view_ChangeButtonEvent;

        }

        private void _view_ChangeButtonEvent()
        {


            if (_view.selectedItemListBox() != -1)
            {

                if (_view.Name.Equals("er") || _view.LastName.Equals("er") || _view.Date.Equals("er") || _view.Salary.Equals("er") || _view.Position.Equals("er") || _view.Agreement.Equals("er"))
                {
                    return;
                }

                string textFormSelectedElement = _view.returnStringListBox();
                _model.change(textFormSelectedElement, _view.Name, _view.LastName, _view.Date, _view.Salary, _view.Position, _view.Agreement);
                _view.clearListBox();

                for (int i = 0; i < _model.employees.Count; i++)
                {
                    _view.addToListBox(_model.employees[i].ToString());

                }
            }
            else { }

        }

        private void _view_EditButtonEvent()
        {


            if (_view.selectedItemListBox() != -1)
            {
                string textFormSelectedElement = _view.returnStringListBox();

                Employee emp = _model.edit(textFormSelectedElement);

                _view.Name = emp.Name;
                _view.LastName = emp.LastName;
                _view.Date = emp.Data;
                _view.Salary = emp.Salary;
                _view.Position = emp.Position;
                _view.checkRadioButton(emp.Arragment);
            }
            else { }


        }

        private void _view_LoadButtonEvent()
        {
            

            _model.Load();
            for (int i = 0; i < _model.employees.Count; i++) {
                _view.addToListBox(_model.employees[i].ToString());
            }

        }

        private void _view_SaveButtonEvent()

        {

            _model.Save();

        }



        private void _view_AddButtonEvent()
        {

            if(_view.Name.Equals("er")||_view.LastName.Equals("er") || _view.Date.Equals("er") || _view.Salary.Equals("er") || _view.Position.Equals("er") || _view.Agreement.Equals("er"))
            {
                return;
            }


            Employee employee = _model.newEmploye(_view.Name, _view.LastName, _view.Date, _view.Salary, _view.Position, _view.Agreement);
            _view.addToListBox(employee.ToString());
            _model.employees.Add(employee);
        }


        
    
    }
}
