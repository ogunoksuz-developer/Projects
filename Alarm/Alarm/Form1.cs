using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alarm
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Timer tmr;

        private void Form1_Load(object sender, EventArgs e)
        {
            // comboboxları doldur.

            SetComboboxSaatItem();
            SetComboboxDakikaItem();
            tmr = new Timer();
            tmr.Enabled = true;
            tmr.Interval = 1000 * 60;
            tmr.Tick += tmr_Tick;
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                string[] zaman = DateTime.Now.ToShortTimeString().Split(':');

                string saat = zaman[0];
                string dakika = zaman[1];

                int i = 0;
                foreach (var items in lstAlarm.Items)
                {

                    ComboboxItem a = (ComboboxItem)items;
                    i++;
                    string[] itm = a.Text.Split(':');

                    string cSaat = itm[0];
                    string cDakika = itm[1];

                    if (saat == cSaat && dakika == cDakika)
                    {
                        SoundPlayer müzik = new SoundPlayer();
                        müzik.SoundLocation = @"D:\Projeler\Alarm\Alarm\thunder.wav";
                        müzik.Play();
                    }
                }
            }
            catch
            {

            }

        }

        private void SetComboboxSaatItem()
        {
            for (int i = 0; i < 24; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = i.ToString();
                item.Value = i.ToString();

                cmbSaat.Items.Add(item);
            }
        }

        private void SetComboboxDakikaItem()
        {
            for (int i = 0; i < 60; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = i.ToString();
                item.Value = i.ToString();

                cmbDakika.Items.Add(item);

            }
        }

        private void btnAlarmKur_Click(object sender, EventArgs e)
        {

            if (cmbSaat.SelectedItem != null && cmbDakika.SelectedItem != null)
            {
                ComboboxItem c = (ComboboxItem)cmbSaat.SelectedItem;
                string saat = c.Text;

                ComboboxItem d = (ComboboxItem)cmbDakika.SelectedItem;
                string dakika = d.Text;

                string alarm = saat + ":" + dakika;

                ComboboxItem item = new ComboboxItem();
                item.Text = alarm;
                item.Value = alarm;

                lstAlarm.Items.Add(item);

                cmbSaat.SelectedIndex = 0;
                cmbDakika.SelectedIndex = 0;

            }
            else
            {
                label2.Text = "!!!!!!!!!!!!!!!!!!!!! ";
            
            }
        }

        private void btnAlarmSil_Click(object sender, EventArgs e)
        {
            lstAlarm.Items.Remove(lstAlarm.SelectedItem);
        }

        private void lstAlarm_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
