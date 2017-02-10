using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class BusinessChargeRawData : BindableBase
    {
        // Найменування та адреса точки обліку
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
        }

        // Тип точки обліку
        private string _type;
        public string Type
        {
            get { return _type; }
            set { SetProperty(ref _type, value); }
        }

        // Тариф, грн/кВт·год
        private string _tariff;
        public string Tariff
        {
            get { return _tariff; }
            set { SetProperty(ref _tariff, value); }
        }

        // Споживання, кВт-год
        private string _consumption;
        public string Consumption
        {
            get { return _consumption; }
            set { SetProperty(ref _consumption, value); }
        }

        // Сума, грн
        private string _sum;
        public string Sum
        {
            get { return _sum; }
            set { SetProperty(ref _sum, value); }
        }
    }
}
