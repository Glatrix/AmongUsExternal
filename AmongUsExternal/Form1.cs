using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using System.Runtime.InteropServices;

namespace AmongUsExternal
{
    public partial class Form1 : Form
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        public Form1()
        {
            InitializeComponent();
        }


        Mem amongus = new Mem();
        public bool gameOpen = false;

        GlobalKeyboardHook current;

        private void Form1_Load(object sender, EventArgs e)
        {
            GameTimer.Interval = 100;
            GameTimer.Start();
            ListTimer.Interval = 500;
            ListTimer.Start();
            current = new GlobalKeyboardHook();
            current.KeyDown += HookedKey_Press;
            current.KeyUp += HookedKey_Lift;
        }


        private void HookedKey_Press(object sender,KeyEventArgs e)
        {
           
        }

        private void HookedKey_Lift(object sender, KeyEventArgs e)
        {
            
        }




        Player localPlayer;


        private void GameTimer_Tick(object sender, EventArgs e)
        {
            GameOpen_Check();
            if (gameOpen)
            {
                //PlayerNameLabel.Text = "Name: " + amongus.ReadString(localPlayerPTR + PC_Name,stringEncoding:Encoding.Unicode);
                localPlayer = new Player(amongus, Player.static_localPlayer);
                NameLabel.Text = "Name: " + localPlayer.Nickname;
                RoleLabel.Text = "Role: " + localPlayer.CurrentRole;
                SpeedLabel.Text = "Speed: " + localPlayer.CurrentSpeed;
                PositionLabel.Text = "Pos: " + "X:" + localPlayer.position.x.ToString() + " Y:" + localPlayer.position.y.ToString();




                if (checkBox1.Checked)
                {
                    localPlayer.NoClip = 0;
                }
                else
                {
                    localPlayer.NoClip = 257;
                }

                if (FullbrightBox.Checked)
                {
                    localPlayer.lighthits = 0;
                    amongus.WriteBytes(Player.AntiFullbright, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                    localPlayer.lightradius = 99;
                }
                else
                {
                    localPlayer.lighthits = 100;
                    amongus.WriteBytes(Player.AntiFullbright, new byte[] { 0xF3, 0x0F, 0x11, 0x46, 0x1C });
                }


               
            }
        }

        private void ListTimer_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (Player.Get_Players(amongus).Count < 1)
            {
                listBox1.Items.Add("Please Join A Game!!");
            }
            else
            {
                listBox1.Items.Add("!![Player List (click to teleport)]!!");

                int i = 1;
                foreach (Player p in Player.Get_Players(amongus))
                {
                    listBox1.Items.Add(i.ToString() + ". " + p.Nickname + " Role: " + p.CurrentRole);
                    i++;
                }
            }






        }

        public void GameOpen_Check()
        {
            if (amongus.theProc == null)
            {
                if (amongus.OpenProcess("Among Us"))
                {
                    GameOpenLabel.Text = "Game: Found!";
                    GameOpenLabel.ForeColor = Color.Green;
                    gameOpen = true;
                }
                else
                {
                    GameOpenLabel.Text = "Game: Not Found.";
                    GameOpenLabel.ForeColor = Color.Red;
                    gameOpen = false;
                }
            }
            if(amongus.theProc != null && amongus.theProc.HasExited)
            {
                if (amongus.OpenProcess("Among Us"))
                {
                    GameOpenLabel.Text = "Game: Found!";
                    GameOpenLabel.ForeColor = Color.Green;
                    gameOpen = true;
                }
                else
                {
                    GameOpenLabel.Text = "Game: Not Found.";
                    GameOpenLabel.ForeColor = Color.Red;
                    gameOpen = false;
                }
            }       
        }

        private void SpeedTB_Scroll(object sender, EventArgs e)
        {
            localPlayer.CurrentSpeed = 0.1f * SpeedTB.Value;
        }

        private void FullbrightBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FullbrightBox.Checked)
            {
                localPlayer.lighthits = 0;
                amongus.WriteBytes(Player.AntiFullbright,new byte[] {0x90,0x90, 0x90, 0x90, 0x90 });
                localPlayer.lightradius = 99;
            }
            else
            {
                localPlayer.lighthits = 100;
                amongus.WriteBytes(Player.AntiFullbright, new byte[] { 0xF3, 0x0F, 0x11, 0x46,0x1C }); 
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                localPlayer.NoClip = 0;
            }
            else
            {
                localPlayer.NoClip = 257;
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string selected = "" + (string)listBox1.SelectedItem;
            foreach(Player p in Player.Get_Players(amongus))
            {
                if (selected.Contains(p.Nickname))
                {
                    localPlayer.position = p.position;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                localPlayer.FreeChat = 1;
            }
            else
            {
                localPlayer.FreeChat = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localPlayer.Nickname = NameChangeBox.Text;
        }
    }




    public class Player
    {
        public static string static_localPlayer = "GameAssembly.dll+01CD414C,5C,20";
        /// <summary>
        /// 0x08 -> Items | 0x0C -> Count | Items count by 4 starting at 0xC
        /// </summary>
        public static string static_AllPlayers = "GameAssembly.dll+01CCE6B0,5C,18";

        /// <summary>
        /// NOP this to change fullbright
        /// </summary>
        public static string AntiFullbright = "GameAssembly.dll+662F53";

        public static string Player_Settings = "GameAssembly.dll+01CCF8D8,5C,68";

        public static string Freechat = "GameAssembly.dll+01DB974C,50,F2C";


        public Mem mem;
        public string address;

        public struct Vector2
        {
            public float x;
            public float y;

            public Vector2(float x, float y)
            {
                this.x = x;
                this.y = y;
            }

            public void set1(float x)
            {
                this.x = x;
            }
            public void set2(float y)
            {
                this.y = y;
            }
            public void set3(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
            public void set4(Vector2 pos)
            {
                this.x = pos.x;
                this.y = pos.y;
            }

        }



        public enum ROLE
        {
            Crewmate,
            Imposter,
            Scientist,
            Engineer,
            Guardian_Angel,
            Shapeshifter
        }


       public static List<Player> Get_Players(Mem mem)
        {
            List<Player> temp_list = new List<Player>();
            int count = mem.ReadInt(static_AllPlayers + ",0C");
            for (int i = 0; i < count; i++)
            {
               string offset = Convert.ToString(0x10 + (0x4 * i),16);
               temp_list.Add(new Player(mem, static_AllPlayers + ",08," + offset));
            }
            return temp_list;
        }

        public Vector2 position
        {
            get
            {
                float codeX = mem.ReadFloat(address + ",64,8,12C,2C");
                float codeY = mem.ReadFloat(address + ",64,8,12C,30");
                return new Vector2(codeX,codeY);
            }
            set
            {
                mem.WriteMemory(address + ",64,8,12C,2C", "float", value.x.ToString());
                mem.WriteMemory(address + ",64,8,12C,30", "float", value.y.ToString());
            }

        }

        public int FreeChat
        {
            set
            {
                mem.WriteMemory(Freechat, "int", value.ToString());
            }
        }

        public int NoClip
        {
            set
            {
                mem.WriteMemory(address + ",64,8,20","int",value.ToString());
            }
        }

        public string Nickname
        {
            get
            {
               return mem.ReadString(address + ",58,80,C", stringEncoding: Encoding.Unicode);
            }
            set
            {
                mem.WriteMemory(address + ",58,80,C","string",value,value.Length,"",Encoding.Unicode);
                mem.WriteMemory(address + ",58,80,8", "int", value.Length.ToString());
            }
        }



        public string CurrentRole
        {
            get
            {
               int role = mem.ReadInt(address + ",3C,18,C");
               return Enum.GetNames(typeof(ROLE))[role];
            }
        }

        /// <summary>
        /// Fullbright 100 = off 0 = on
        /// </summary>
        public int lighthits
        {
            set
            {
                mem.WriteMemory(address + ",60,28,0C","int",value.ToString());
            }
        }



        public float lightradius
        {
            set
            {
                mem.WriteMemory(address + ",60,1C", "float", value.ToString());
            }
        }

        public float CurrentSpeed
        {
            get
            {
               return mem.ReadFloat(address + ",68,28");
            }
            set
            {
                mem.WriteMemory(address + ",68,28","float",value.ToString());
                mem.WriteMemory(address + ",68,2C", "float", value.ToString());
            }
        }


        public Player(Mem memory, string pointer)
        {
            mem = memory; address = pointer; 
        }
    }
}
