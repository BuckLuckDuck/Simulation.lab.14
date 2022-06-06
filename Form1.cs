using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation.lab._14
{
    public partial class Form1 : Form
    {
        
        systemTemp bank;
        humanGenerator generator;
        le_operatori oper_une;
        le_operatori oper_deux;
        le_operatori oper_trois;

        public Form1()
        {
            InitializeComponent();
            oper_une = new le_operatori(btn_oper_1);
            oper_deux = new le_operatori(btn_oper_2);
            oper_trois = new le_operatori(btn_oper_3);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        

    }
    // 1. Генератор создает число, через какое время появиться новый человек
    // 2. Генератор создает человека
    // 3. Если есть свободной опер
    // 4. Клиент отрправляется к оператору => оператор становиться занятым
    // 5. Если фрии опер нет, то куе + 1

    public class humanGenerator
    {
        void GenerateHuman(systemTemp obj)
        {
            obj.AddHumanToQueue();
        }


    }

    public class systemTemp
    {

        public int queue = 0;

        public void AddHumanToQueue()
        {
            queue += 1;
        }
        public void DeleteHumanFromQueue()
        {
            queue += -1;
        }
    }

    public class le_operatori
    {
        Button box;
        bool isFree;

        public le_operatori(Button btn_le_opera)
        {
            isFree = true;
            box = btn_le_opera;
            box.BackColor = Color.Lime;
        }
    }
}
