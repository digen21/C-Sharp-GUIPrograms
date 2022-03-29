# tic tac toe game instruction

 1. Take tablelaoutpanel window form toolbox

2. Take 9 buttons and set in lable layout panel

3. Change the text of button and leave it blank.Change button name b1,b2 upto button 9;

4. Now by pressing control button select all the nine buttons and double click on button 1;
	>>Now rename b1 to button_Click


5. Now goto form design window and go to event block and you will see there is a "Click Event"...
	>> Now click on it and select the renamed name that is("button_Click");

		---------------- The Main Part Is Start Now ----------------
6. Now go in coding part/button_click class....
	>> Now create the object for those 9 buttons as following........
		
		// But before that declaring variable is necessary
		
		// So in coding part you can see there is following class is already available


			public partial class tictac : form
			{
				
				//declare the varibles here....
				String  a = "O"; 
        			int m = 0; 
				public tictac()
				{
					InitializeComponent();
				}


		private void button_Click(object sender, EventArgs e)
			{

			Button bt = sender as Button 
					OR
			Buttton bt = (Button)sender;    // bt is object name
			bt.Enbled = false;
			bt.BackColor = Color.Green;     //Here event is created so while player click on any button it will turn into green color
			if(a == "O")
			{
				bt.Text = "O";
				
				//Now creating possible combinations of tic tac toe game
				// such as 123, 456, 789, 147, 258, 369, 159, 357
				// These conditions are for "O" 
				if((b1.Text == b2.Text && b2.Text && b3.Text && b2.Text != "") ||
				   (b4.Text == b5.Text && b5.Text && b6.Text && b5.Text != "") ||
				   (b7.Text == b8.Text && b8.Text && b9.Text && b8.Text != "") ||
				   (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    	   (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    	   (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    	   (b1.Text == b5.Text && b5.Text == b7.Text && b5.Text != "") ||
                    	   (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
				    {
					Message.Show(("The Winner Is: " + a.ToString()));
				    }
					
					//Now Making the draw condition incase if all the box were filled
					else if(m == 8)
					{
					   Message.Show("Draw!!");
					}
					a = "X";
					//Now Making the same conditons for the "X";
					else if(a == "X")
					{
						bt.Text = "X";
						//Making all the possible condtions for the winning of X
						if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                    			    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    			    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    			    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    			    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    			    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    			    (b1.Text == b5.Text && b5.Text == b7.Text && b5.Text != "") ||
                    			    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
               		      {
						MessageBox.Show(("The Winner Is: " + a.ToString()));
						
					}
					else if(a == 8)
					{
						MessageBox.Show("Draw!!");
					}
					a = "O";
					}
					m++;
			}

					// Now Coding for NewGame/(Reset)........
					// For These Create a button to reset or new game
					// Here the occurance of event is something like this.....
							>> if we click on newgame the box must be turn into white box 
								>> & the box will become blank..  Right....!!
					
					//Double Click on new game/ reset button...
					//Change the text of button to new button / reset
					
					{
					a = "O";
					m = 0;
					b1.Enabled = true; b1.Text = ""; b1.BackColor = Color.White;
					//now write same code for other 8 buttons.....
					 b2.Enabled = true; b2.Text = ""; b2.BackColor = Color.White;
            			 b3.Enabled = true; b3.Text = ""; b3.BackColor = Color.White;
          				 b4.Enabled = true; b4.Text = ""; b4.BackColor = Color.White;
           				 b5.Enabled = true; b5.Text = ""; b5.BackColor = Color.White;
           				 b6.Enabled = true; b6.Text = ""; b6.BackColor = Color.White;
           				 b7.Enabled = true; b7.Text = ""; b7.BackColor = Color.White;
           				 b8.Enabled = true; b8.Text = ""; b8.BackColor = Color.White;
           				 b9.Enabled = true; b9.Text = ""; b9.BackColor = Color.White;
					 tableLayoutPanel1.Enabled = true;
					}




Here I used enabled: As per google it means that it enables the control at runtime
Source Code: From Youtube...











