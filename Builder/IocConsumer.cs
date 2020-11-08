using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Builder
{
    public class IocConsumer
    {
        public int D (int i )
        {
            return SimpleIoc.Default.GetInstance<IIface>().Doppio(i);
        }
    }
}
