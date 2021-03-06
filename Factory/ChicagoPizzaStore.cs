﻿namespace FactoryMethod
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if(type.ToLower() == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }

            if (type.ToLower() == "veggie")
            {
                return new ChicagoStyleVeggiePizza();
            }

            return null;
        }
    }
}
