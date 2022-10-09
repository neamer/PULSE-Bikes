﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.WinUI.Helpers
{
    public class EnvironmentHelper
    {
        public static bool IsInRuntimeMode(IComponent component)
        {
            bool ret = IsInDesignMode(component);
            return !ret;
        }

        public static bool IsInDesignMode(IComponent component)
        {
            bool ret = false;
            if (null != component)
            {
                ISite site = component.Site;
                if (null != site)
                {
                    ret = site.DesignMode;
                }
                else if (component is System.Windows.Forms.Control)
                {
                    IComponent parent = ((System.Windows.Forms.Control)component).Parent;
                    ret = IsInDesignMode(parent);
                }
            }

            return ret;
        }
    }
}
