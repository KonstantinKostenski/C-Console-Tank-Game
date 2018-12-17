namespace TheTankGame.Core
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly IManager tankManager;

        public CommandInterpreter(IManager tankManager)
        {
            this.tankManager = tankManager;
        }

        public string ProcessInput(IList<string> inputParameters)
        {
            string command = inputParameters[0];
            if (inputParameters.Count > 1)
            {
                inputParameters = inputParameters.Skip(1).ToList();
            }

            string result = string.Empty;
            var type = typeof(TankManager);

            if (command == "Vehicle" || command == "Part")
            {
                command = "Add" + command;
            }

            var method = type.GetMethod(command);
            result = (string)method.Invoke(tankManager, new object[] { inputParameters });

            return result;
        }
    }
}