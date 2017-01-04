using AbstractFactory;
using Adapter;
using Bridge;
using Builder;
using ChainOfResponsibility;
using Command;
using Composite;
using Facade;
using Flyweight;
using Mediator;
using Memento;
using Observer;
using Prototype;
using Singleton;
using State;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod;
using Interpreter;
using Visitor;
using Decorator;
using Proxy;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //原型模式
            //ConcretePrototype p1 = new ConcretePrototype("I");
            //ConcretePrototype p2 = p1.Clone() as ConcretePrototype;
            //Console.WriteLine("Cloned:{0}", p1.Id);
            //Console.Read();

            //Resume a = new Resume("伊布");
            //a.SetPersonallInfo("男", 32);
            //a.SetWorkExperience("2011-2016", "巴黎圣日耳曼");

            //Resume b = (Resume)a.Clone();
            //b.SetWorkExperience("2016-2017", "曼联");

            //Resume c = (Resume)a.Clone();
            ////c.SetPersonallInfo("男",28);
            //c.SetWorkExperience("2017-XX","未知");

            //a.Display();
            //b.Display();
            //c.Display();

            //模板方法模式
            //AbstractClass c;

            //c = new ConcreteClassA();
            //c.TemplateMethod();

            //c = new ConcreteClassB();
            //c.TemplateMethod();

            //外观模式
            //Facade.Facade facade = new Facade.Facade();
            //facade.MethodA();
            //facade.MethodB();

            //建造者模式
            //Director director = new Director();
            //Builder.Builder b1 = new ConcreteBuilder1();
            //director.Construct(b1);
            //Product product = b1.GetResult();
            //product.Show();

            //观察者模式
            //ConcreteSubject s = new ConcreteSubject();

            //s.Attach(new ConcreteObserver(s, "X"));
            //s.Attach(new ConcreteObserver(s, "Y"));
            //s.Attach(new ConcreteObserver(s, "Z"));

            //s.SubjectState = "Ready";
            //s.Notify();

            Boss huhansan = new Boss();

            //看股票的同事
            //StockObserver tongshil = new StockObserver("马蓉", huhansan);
            //看NBA的同事
            //NBAObserver tongshi2 = new NBAObserver("易茶冠", huhansan);

            //huhansan.Update += new Observer.EventHandler(tongshil.CloseStockMarket);
            //huhansan.Update += new Observer.EventHandler(tongshi2.CloseNBADirectSeeding);

            //huhansan.SubjectState = "我胡汉三回来了";

            //huhansan.Notify();

            //抽象工厂
            //Department department = new Department();
            //IFactory factory = new MysqlFactory();
            ////IDepartment idpt = factory.CreateDepartment();
            //IDepartment idpt = DataAccess.CreateDepartment();
            //idpt.Insert(department);

            //状态模式
            //Context c = new Context(new ConcreteStateA());
            //c.Request();
            //c.Request();
            //c.Request();
            //c.Request();

            //适配器模式
            //Target target = new Adapter.Adapter();
            //target.Request();

            //备忘录模式
            //Originator o = new Originator();
            //o.State = "On";
            //o.Show();

            //Caretaker c = new Caretaker();
            //c.Memento = o.CreateMemento();

            //o.State = "Off";
            //o.Show();

            //o.SetMemento(c.Memento);
            //o.Show();

            //组合模式
            //Composite.Composite root = new Composite.Composite("root");
            //root.Add(new Leaf("Leaf A"));
            //root.Add(new Leaf("Leaf B"));

            //Composite.Composite comp = new Composite.Composite("Composite X");
            //comp.Add(new Leaf("Leaf XA"));
            //comp.Add(new Leaf("Leaf XB"));

            //root.Add(comp);

            //Composite.Composite comp2 = new Composite.Composite("Composite XY");
            //comp2.Add(new Leaf("Leaf XYA"));
            //comp2.Add(new Leaf("Leaf XYB"));

            //comp.Add(comp2);

            //root.Add(new Leaf("Leaf C"));
            //Leaf leaf = new Leaf("Leaf D");

            //root.Add(leaf);
            //root.Remove(leaf);

            //root.Display(1);

            //单例模式
            Singleton.Singleton s = Singleton.Singleton.GetInstance();

            //桥接模式
            //Abstraction ab = new RefinedAbstraction();

            //ab.SetImplementor(new ConcreteImplementor());
            //ab.Operation();

            //ab.SetImplementor(new ConcreteImplementorB());
            //ab.Operation();

            //命令模式
            //Receiver r = new Receiver();
            //Command.Command c = new ConcreteCommand(r);
            //Invoker i = new Invoker();
            //i.SetCommand(c);
            //i.ExecuteCommand();

            //责任链模式
            //Handler h1 = new ConcreteHandlerA();
            //Handler h2 = new ConcreteHandlerB();
            //Handler h3 = new ConcreteHandlerC();

            //h1.SetSuccessor(h2);
            //h2.SetSuccessor(h3);

            //int[] requests = { 1, 3, 14, 25, 19, 29, 31 };
            //foreach (int request in requests)
            //{
            //    h1.HandlerRequest(request);
            //}

            //中介模式
            //ConcreteMediator m = new ConcreteMediator();

            //ConcreteColleagueA a = new ConcreteColleagueA(m);
            //ConcreteColleagueB b= new ConcreteColleagueB(m);

            //m.ColleagueA = a;
            //m.ColleagueB = b;

            //a.Send("吃了吗？");
            //b.Send("没呢，你请客？");

            //享元分享
            //int extrinsicstate = 22;

            //FlyweightFactory f = new FlyweightFactory();
            //Flyweight.Flyweight fx = f.GetFlyweight("X");
            //fx.Operation(--extrinsicstate);

            //Flyweight.Flyweight fy = f.GetFlyweight("Y");
            //fy.Operation(--extrinsicstate);

            //Flyweight.Flyweight fz = f.GetFlyweight("Z");
            //fz.Operation(--extrinsicstate);

            //UnsharedConcreteFlyweight uf = new UnsharedConcreteFlyweight();
            //uf.Operation(--extrinsicstate);

            //解释器模式
            //Interpreter.Context context = new Interpreter.Context();
            //IList<AbstractExpression> list = new List<AbstractExpression>();
            //list.Add(new TerminalExpression());
            //list.Add(new NonterminalExpression());
            //list.Add(new TerminalExpression());
            //list.Add(new TerminalExpression());

            //foreach (var exp in list)
            //{
            //    exp.Interpret(context);
            //}

            //访问者模式
            //ObjectStructure o = new ObjectStructure();
            //o.Attach(new ConcreteElementA());
            //o.Attach(new ConcreteElementB());

            //ConcreteVisitorA va = new ConcreteVisitorA();
            //ConcreteVisitorB vb = new ConcreteVisitorB();

            //o.Accept(va);
            //o.Accept(vb);

            //装饰模式
            //ConcreteComponet c = new ConcreteComponet();
            //ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            //ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            //d1.SetComponent(c);
            //d2.SetComponent(d1);
            //d2.Operation();

            //代理模式
            Proxy.Proxy p = new Proxy.Proxy();
            p.Request();

            Console.Read();
        }
    }
}
