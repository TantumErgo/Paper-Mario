using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paper_Mario
{
    public partial class TattleDebugForm : Form
    {
        public TattleDebugForm()
        {
            InitializeComponent();
        }

        //NOTE: Below is commented out because it uses conventions from a previous Build and now causes errors. It can be refactored and used
        //      again for debugging if necessary; MUST ALSO uncomment Line 43 in TattleDebugForm.Designer.cs for this code to work
        //private void tattleTestButton_Click(object sender, EventArgs e)
        //{
        //    using (var db = new EnemyDatabaseContext4())
        //    {
        //        var query = from g in db.Enemies
        //                    //where g.EnemyId == SpikedGoomba.ID
        //                    //test commands
        //                    //where g.EnemyId == Goomba.ID
        //                    where g.EnemyId == Paragoomba.ID
        //                    select g;

        //        foreach (var item in query)
        //        {
        //            TattleForm tattleForm = new TattleForm(item);
        //            tattleForm.ShowDialog();

        //            //.tattleNameLabel.Text = "";
        //        }
        //    }
               
        //}

        private void tattleLogDebugButton_Click(object sender, EventArgs e)
        {
            TattleLogForm tattleLog = new TattleLogForm();
            tattleLog.ShowDialog();
        }
    }
}
