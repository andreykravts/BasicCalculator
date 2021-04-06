using System;

using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace BasicCalculator
{

    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {

        #region constructor
        /// <summary>
        /// Default cinstructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

        }

        #endregion

        #region AM_I_NEED_THIS?


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }
        #endregion


        #region clearing methods
        /// <summary>
        /// clear the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event ARGUMENTS </param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //clear the text from user input text box
            this.UserInputText.Text = string.Empty;
            //Focus the user input text
            FocusInputText();
        }



        /// <summary>
        /// Delete the first character in front of the cursor
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void DELButton_Click(object sender, EventArgs e)
        {
            //Delete the value after the selected position 
            DeleteTextValue();
            // Focus the user input text 
            FocusInputText();
        }
        #endregion


        #region form
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Operator Functions
        /// <summary>
        /// Adds the Divide character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>


        private void MODULOButton_Click(object sender, EventArgs e)
        {//divide
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("/");
            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds the Times character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        /// 
        private void MULTIPLYButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("*");
            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds the Minus character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        /// 
        private void MINUSButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("-");
            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Calculates the given equation in the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        /// 
        private void EQUALSButton_Click(object sender, EventArgs e)

        {
            //Calculate the Equation
            CalculateEquation();
            // Focus the user input text 
            FocusInputText();


        }
        private void PLUSButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("+");
            // Focus the user input text 
            FocusInputText();
        }
        #endregion

        #region Numbers Methods
        private void SEVENButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("7");
            // Focus the user input text 
            FocusInputText();
        }

        private void DOTButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue(".");
            // Focus the user input text 
            FocusInputText();
        }
        private void EIGHTButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("8");
            // Focus the user input text 
            FocusInputText();
        }

        private void NINEButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("9");
            // Focus the user input text 
            FocusInputText();
        }



        private void FOURButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("4");
            // Focus the user input text 
            FocusInputText();
        }

        private void FIVEButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("5");
            // Focus the user input text 
            FocusInputText();
        }

        private void SIXButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("6");
            // Focus the user input text 
            FocusInputText();
        }



        private void ONEButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("1");
            // Focus the user input text 
            FocusInputText();
        }

        private void TWOButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("2");
            // Focus the user input text 
            FocusInputText();
        }

        private void THREEButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("3");
            // Focus the user input text 
            FocusInputText();
        }



        private void ZEROButton_Click(object sender, EventArgs e)
        {
            // insert the value in the user input text box at the currently selected position
            InsertTextValue("0");
            // Focus the user input text 
            FocusInputText();
        }


        #endregion


        #region 
        ///samary calculates the given equation and outputs the answer to the user label
        private void CalculateEquation()
        {
            //TODO: Finish
           

            // 3. Recursive functions
            // 4. Switch statements

            //var result = ParseOperation();

            this.CalculationResultText.Text = ParseOperation();


            // focus the user input text
            FocusInputText();


        }
        /// <summary>
        /// Parses the users  equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                //get the user equation input
                var input = this.UserInputText.Text;

                //remove all spaces
                input = input.Replace(" ","");

                //create a new top level operation
                var operation = new Operation();
                var leftSide = true;

                //Loop through each character of input
                //starting from the left walking to the right
                for(int i = 0; i < input.Length; i++)
                {
                    //TODO:
                    //Handle order priority
                    // 4 + 5 * 3
                    // it should calculate 5 times 3 5*3 first and then make result + 4 (so 15 + 4)


                    //check if the current character is the number
                    
                    if ("01234567890.".Any(c => input[i] == c))
                    {
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        else
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                    }
                    //if it is An operator (+ - * / ) set the operator type
                    else if ("+-*/.".Any(c => input[i] == c))
                    {
                        // if we are on the right side already, we now need to calculate our current operation 
                        // and set the result to the left side of the next operation 
                        if(!leftSide)
                        {
                            //get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // check if we actually have a right side number
                            if (operation.RightSide.Length == 0)
                            {
                                //-4 + 5
                                //check the operator in not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (* + / or more than one -) specified without an right side number ");
                                //if we got here the operator type is minus, and there is no right number currently, so add the minus to the number
                                operation.RightSide += input[i];
                            }
                            else
                            {
                                //Calculate previous equation and set to the left side
                                operation.LeftSide = CalculateOperation(operation);
                                // Set new operator
                                operation.OperationType = operatorType;
                                //Clear the previos right number 
                                operation.RightSide = string.Empty;

                            }

                        }
                        else
                        {
                            //get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // check if we actually have a left side number
                            if(operation.LeftSide.Length==0)
                            {
                                //-4 + 5
                                //check the operator in not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (* + / or more than one -) specified without an left side number ");
                                //if we got here the operator type is minus, and there is no left number currently, so add the minus to the number
                                operation.LeftSide += input[i]; 
                            }
                            else
                            {
                                //if we get there, we have a left number and now an operator, so we want to move to the right side

                                //set the operation type 
                                operation.OperationType = operatorType;

                                // move to right side 
                                leftSide = false;
                            }
                        } 
                    }
                }
                //if we are done parsing , and there were no exceptions 
                //calculate the current operation
                return CalculateOperation(operation);
                
            }
            catch (Exception ex)
            {
                return $"Invailed equation. {ex.Message}";
            }
        }
        /// <summary>
        /// Calculates an <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation">the operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            //store the number values of the string representations 
            double left = 0;
            double right = 0;
            // check if we have a valid left side number 
            if (string.IsNullOrEmpty(operation.LeftSide) || !double.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.LeftSide}");

            // check if we have a valid right side number 
            if (string.IsNullOrEmpty(operation.RightSide) || !double.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Right side of the operation was not a number. {operation.RightSide}");

            try 
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation. {operation.OperationType}");

                }
            }
            catch (Exception ex) 
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");
            }

            return String.Empty;
        }




        /// <summary>
        /// Accepts the character and return the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">character to parce</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;
                    
                case '-':
                    return OperationType.Minus;
                    
                case '/':
                    return OperationType.Divide;
                    
                case '*':
                    return OperationType.Multiply;
                    

                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");
            }

        }

        /// <summary>
        /// Attempts to add new character to the current number , checking for valid characters as it goes
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="newCharacter">The new character to append to the string </param>
        /// <returns></returns>

        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // check if there is already a . in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");
            return currentNumber + newCharacter;
        }
        #endregion

        #region Privet Helpers
        /// <summary>
        /// Focusesthe user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }
        /// <summary>
        /// Insert the given text into the user input textbox
        /// </summary>
        /// <param name="value">the value to insert</param>
        private void InsertTextValue(string value)
        {
            //remember selection start
            var selectionStart = this.UserInputText.SelectionStart;
            //set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            //set selection lenght to zero
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Delete the character to the right of the selection start of the user input textbox
        /// </summary>


        private void DeleteTextValue()
        {
            // If we dont have a value to delete , than return (than we do nothing)
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            //remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Delete the character to the right of the selection

            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            //set selection lenght to zero
            this.UserInputText.SelectionLength = 0;
        }
        #endregion


    }

}
