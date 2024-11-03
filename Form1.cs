using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [Route("api/[Controller]")]
        [ApiController]
        public class NameController : ControllerBase{
            [HttpGet]
            public IActionResult GetName(){
                return Ok(new{ name = "Alexia"});
            }
        }

    }
}
