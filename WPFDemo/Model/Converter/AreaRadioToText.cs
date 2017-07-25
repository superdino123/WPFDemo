using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WPFDemo.ViewModel.Enum;

namespace WPFDemo.Model.Converter
{
    public class AreaRadioToText:IValueConverter
    {
        /// <summary>
        /// 显示框绑定单选框的选择结果，单项绑定
        /// </summary>
        private IValueConverter _valueConverterImplementation;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool area = (bool) value;
            if (area)
            {
                return AreaEnum.ShangHai;
            }
            else
            {
                return AreaEnum.ShenZhen;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return _valueConverterImplementation.ConvertBack(value, targetType, parameter, culture);
        }
    }
}
