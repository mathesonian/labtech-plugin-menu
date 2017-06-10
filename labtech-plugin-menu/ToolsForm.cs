using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LabTech.Interfaces;

namespace labtech_plugin_menu
{
    /// <summary>
    /// Form to be loaded from the MenuItem in the Tools Menu.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ToolsForm : Form
    {
        /// <summary>
        /// The IControlCenter object.
        /// </summary>
        private IControlCenter objHost;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsForm"/> class.
        /// </summary>
        public ToolsForm()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsForm"/> class, initializes control components, and sets IControlCenter object.
        /// </summary>
        /// <param name="objHost">The IControlCenter object.</param>
        public ToolsForm(IControlCenter objHost)
        {
            InitializeComponent();
            this.objHost = objHost;
        }
    }
}
