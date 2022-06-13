namespace Shopping
{
    class Product
    {
        public string name  { get; set; }
        public int price { get; set; }
        public int stock { get; set; }



        public void buyProduct(int quantity){

            if(quantity >= 1){ // Confirm whether the user has not provided a negative value

                if(stock >= quantity){ // Confirm whether the we have enough items in stock

                    stock -= quantity; // we are carrying out the main goal
                }else{
                    Console.WriteLine("You can order upto "+ stock + " Item(s)");
                }

            }else{
                Console.WriteLine("Invalid Quantity");
            }
        }
    }
}