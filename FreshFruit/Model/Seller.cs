using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshFruit.Controller;

namespace FreshFruit.Model
{
    class Seller
    {
        private string name;
        private BucketController bucket;

        public Seller(string name, BucketController bucket)
        {
            this.name = name;
            this.bucket = bucket;
        }

        public List<Fruit> findAll()
        {
            return this.bucket.findAll();
        }

        public void addFruit(Fruit fruit)
        {
            this.bucket.addFruit(fruit);
        }

        public void rmvFruitreiihunn(Fruit fruit)
        {
            this.bucket.removeFruitr3i(fruit);
        }

    }

}
