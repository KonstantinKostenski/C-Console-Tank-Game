namespace TheTankGame.Core
{
    using System;

    using Contracts;
    using IO.Contracts;

    public class Engine : IEngine
    {
        private bool isRunning;
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(
            IReader reader, 
            IWriter writer, 
            ICommandInterpreter commandInterpreter)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandInterpreter = commandInterpreter;

            this.isRunning = false;
        }

        public void Run()
        {
            this.isRunning = true;

            while (isRunning)
            {
                string input = this.reader.ReadLine();
                if (input == "Terminate")
                {
                    this.isRunning = false;
                }
                //try
                //{
                    string[] tokens = input.Split();
                    this.writer.WriteLine(this.commandInterpreter.ProcessInput(tokens));
                //}
                //catch (Exception ex)
                //{
                //    this.writer.WriteLine(ex.Message);
                //}

            }
        }
    }
}