﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LabelImage
{
    public class ZoomInCommand : ICommand
    {

        public ZoomInCommand()
        {
        }

        public bool CanExecute(object parameter)
        {
            return App.CurrentZoomFactor >= App.MaxZoomFactor;
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;
    }
}
