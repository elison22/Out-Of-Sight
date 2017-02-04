using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OutOfSight.Game;

namespace OutOfSight {
    public partial class MainWindow : Form {

        GameFacade game = new GameFacade();
        List<int> selectedCards = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Timer fired at " + DateTime.Now.TimeOfDay);
        }

        private void MenuItem_File_NewGame_Click(object sender, EventArgs e)
        {
            // select players
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
