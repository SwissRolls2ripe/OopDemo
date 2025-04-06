using System;

namespace OopDemo
{
    // 抽象类Animal，定义动物的基本行为
    public abstract class Animal
    {
        // 动物名称属性
        public string Name { get; set; }

        // 构造函数，接收名称参数
        protected Animal(string name)
        {
            Name = name;
        }

        // 抽象方法，用于定义动物发声的行为
        public abstract void MakeSound();
    }
}