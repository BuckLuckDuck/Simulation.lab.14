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
        public int time_new_client;

        void GenerateHuman(systemTemp obj)
        {
            obj.AddHumanToQueue();
        }

        void time_cheker(systemTemp obj, int average)
        {
            if (time_new_client == 0)
            {
                GenerateHuman(obj);
                time_new_client = obj.getTime(average);
            }
        }

        humanGenerator()
        {
            time_new_client = 0;
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

        public int getTime(int average)
        {
            double sum = 0;
            int m = 0;

            Random rnd = new Random();

            sum += Math.Log(rnd.Next());
            while (sum >= -average)
            {
                m++;
                sum += Math.Log(rnd.Next());
            }
            return m;
        }
    }

    public class le_operatori
    {
        Button box;
        bool isFree;
        int service_time;

        public le_operatori(Button btn_le_opera)
        {
            isFree = true;
            box = btn_le_opera;
            service_time = 0;
            box.BackColor = Color.Lime;
        }

        void time_cheker()
        {
            if (service_time == 0)
            {
                isFree = true;
                box.BackColor = Color.Lime;
            }
        }

        void notFree()
        {
            isFree = false;
            box.BackColor = Color.IndianRed;
        }
    }
}