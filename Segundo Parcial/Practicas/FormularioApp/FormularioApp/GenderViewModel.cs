using System;
using System.Collections.Generic;
using UIKit;

namespace FormularioApp
{
    public class GenderViewModel : UIPickerViewModel
    {
        public event EventHandler genderChange;

        List<string> list;
        public GenderViewModel(List<string> plist)
        {
            list = plist;
        }

		public override void Selected(UIPickerView pickerView, nint row, nint component)
		{
            //base.Selected(pickerView, row, component);
            var gender = list[(int)row];
            genderChange?.Invoke(null, null);
		}

		public override string GetTitle(UIPickerView pickerView, nint row, nint component)
		{
            //return base.GetTitle(pickerView, row, component);
            var genderString = list[(int)row];
            return genderString;
		}
	}
}
