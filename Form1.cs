using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpyPhone
{
    public partial class phone : Form
    {
        public phone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateMessage();
            richTextBox.ScrollToCaret();
        }

        private void generateMessage()
        {
            Boolean lkdown = false;
            string[] types = {"item", "city", "swap agent", "score agent", "demote", "promote"};
            //debug:
            Random random = new Random();
            int rnd = random.Next(types.Length);
            string type = types[rnd];
            //debug: string type = types[4];

            if(type.Equals("item")) {
                string[] itemBin = {"briefcase", "gun", "folder", "phone", "diamond", "microchip", "Laptop"};
                rnd = random.Next(itemBin.Length);
                String item = itemBin[rnd];
                string[] items = {
                    "Stopped at customs! Scan ur Activity cards. If u have the " + item + ", discard ur Mission card & take a new 1.",
                    "Web virus! All scan ur Activity cards. If u have the " + item + " u must discard those cards & take new ones!" };
                int choice = random.Next(items.Length);
                //Console.WriteLine(items[choice]);
                richTextBox.AppendText(items[choice] + "\n");
            }

            if (type.Equals("city")) {
           
                string[] Messages = {
                    "Parachute drop. Move 1 agent of ur choice to any city on the board.",
                    "The Big Apple! Move 1 agent of ur choice to NEW YORK.",
                    "Rush to Russia! Move 1 agent of ur choice 2 MOSCOW.",
                    "Trouble down under! Move 1 agent of ur choice 2 SYDNEY.",
                    "Stars in your eyes! Move 1 agent of ur choice 2 LOS ANGELES.",
                    "Guten Tag! Move 1 agent of ur choice 2 BERLIN.",
                    "Don't fall in love out there! Move 1 agent of ur choice 2 PARIS.",
                    "Time 2 use ur karate moves! Move 2 agents of ur choice to TOKYO.",
                    "Ask Big Ben what time it is. Move 1 agent of ur choice 2 LONDON.", 
                    "Who is Dale? Move 1 agent of ur choice 2 MIAMI.",
                    "Go Now! Move 1 agent of ur choice to C.L.U.E.",
                    "Ponerse las pilas! Move 1 agent of ur choice to BUENOS AIRES.",
                    "The caper is afoot! Move 1 agent of ur choice to CAPE TOWN.",
                    "Cricket perhaps? Move 1 agent of ur choice to SINGAPORE." // check to see if there is a better saying later 
                };
                int choice = random.Next(Messages.Length);
                //Console.WriteLine(Messages[choice]);
                richTextBox.AppendText(Messages[choice] + "\n");
            }

            if (type.Equals("swap agent")) {

         
                string[] Messages = {
                "Reassignment! Swap ur Mission card with any other player's card. DO NOT look at the cards b4 u choose!",
                "Imposter! Swap ur Secret ID card with another player's Secret ID card. Don't look @ the cards b4 u choose!",
                "Back 2 base! Move all agts back 2 their home cities. If a city has a white 'X' token, that agt doesnt move.",
                "Cover's blown! Pick a player.  They must reveal their secret identity 2 every 1, but score 1pt 4 their agent."
                };
                int choice = random.Next(Messages.Length);
                //Console.WriteLine(Messages[choice]);
                richTextBox.AppendText(Messages[choice] + "\n");
            }

            if (type.Equals("score agent")) {

            
                string[] Messages = {
                    "Surveillance! If Agt Peacock is NOT activated, she gets 1 pt. If she IS, any agent of ur choice gets 1 pt.",
                    "It's not over yet! Move Agt Black 1 space UP the track.",
                    "Deadly charms! If Agt Scarlet is NOT activated, she gets 1 pt. If she IS, an agent of ur choice gets 1 pt.",
                    "Stealth tactics! If Agt White is NOT activated, she gets 1 pt. If she IS, any agent of ur choice gets 1 pt.",
                    "Computer hack! If Plum is NOT activated, he gets 1 point. If he IS, any other agent of ur choice gets 1 pt.",
                    "Cracked the safe! If Mustard is NOT activated, he gets 1 point. If he IS, an agent of ur choice gets 1 pt.",
                    "The con is on! If agt Green is NOT activated, he gets 1 point. If he IS, an agent of ur choice gets 1 pt."
                };
                int choice = random.Next(Messages.Length);
                //Console.WriteLine(Messages[choice]);
                richTextBox.AppendText(Messages[choice] + "\n");
            }

            if (type.Equals("promote"))
            { 
                string[] Messages = {
                 "Double cross! Steal a complete Secret Mtg card from any other player - it's urs now!",
                 "Code breaker! Take free peek at the Secret Mtg card 2 see which agent is on there. Don't tell any1!",
                 "Private jet! Move 2 agents 2 the Secret Mtg city. Scan mtg card. If correct agents are there,score as usual.",
                 "New intelligence! Move item from any agent's space onto an empty city of ur choice.",
                 "Easy as spy! If any agent has 1 of the items on ur current Mission card, you completed the mission.",
                };
                int choice = random.Next(Messages.Length);
                //Console.WriteLine(Messages[choice]);
                richTextBox.AppendText(Messages[choice] + "\n");
            }

            if (type.Equals("demote"))
            {

                string[] Messages = {
                "Lockdown warning! Whew! That was close!", // position 0 gets overwritten
                "Cover's blown! U must reveal ur secret identity 2 the other players but you score 1pt 4 ur agent.",
                "Cover's blown! Pick a player. They must reveal their secret identity 2 every1, but score 1pt 4 their agent.",
                "Back 2 base! Move all agts back 2 their home cities. If a city has a white 'X' token, that agt doesnt move.",
                "Imposter! Swap ur Secret ID card with another player's Secret ID card. Don't look @ the cards b4 u choose!",
                
                };

                int choice = random.Next(Messages.Length);

                if (choice == 0 && lkdown == false) 
                {
                    lkdown = true;
                    string[] city = {"PAIRS", "NEW YORK", "MOSCOW", "SYDNEY", "LOS ANGELES", "TOKYO", "BERLIN",
                                    "LONDON", "MIAMI", "BUENOS AIRES", "CAPE TOWN", "SINGAPORE"};
                    int cn = random.Next(city.Length);
                    string msg = "Lockdown! Close off " + city[cn] + " 4 rest of game. Put white 'X' token on this city. Agts can exit but not re-enter.";
                    //Console.WriteLine(msg);
                    richTextBox.AppendText(msg + "\n");
                }
                else {
                    //Console.WriteLine(Messages[choice]);
                    richTextBox.AppendText(Messages[choice] + "\n");
                }
            }
        }

       
    }
}
