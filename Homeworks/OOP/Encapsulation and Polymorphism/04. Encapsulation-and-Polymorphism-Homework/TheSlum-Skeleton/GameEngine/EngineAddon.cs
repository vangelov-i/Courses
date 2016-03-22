
namespace TheSlum.GameEngine
{
    using Items;
    public class EngineAddon : Engine
    {
        protected override void CreateCharacter(string[] inputParams)
        {
            Team team = Team.Blue;
            if (inputParams[5] == "Red")
            {
                team = Team.Red;
            }
            switch (inputParams[1])
            {
                case "mage":
                    this.characterList.Add(new Mage(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), team));
                    break;
                case "warrior":
                    this.characterList.Add(new Warrior(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), team));
                    break;
                default:
                    this.characterList.Add(new Healer(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), team));
                    break;
            }
        }


        protected void AddItem(string[] inputParams)
        {
            Character acceptingItem = GetCharacterById(inputParams[1]);

            switch (inputParams[2])
            {
                case "axe":
                    acceptingItem.AddToInventory(new Axe(inputParams[3]));
                    break;
                case "pill":
                    acceptingItem.AddToInventory(new Pill(inputParams[3]));
                    break;
                case "injection":
                    acceptingItem.AddToInventory(new Injection(inputParams[3]));
                    break;
                default:
                    acceptingItem.AddToInventory(new Shield(inputParams[3]));
                    break;
            }
        }

        protected override void ExecuteCommand(string[] inputParams)
        {
            base.ExecuteCommand(inputParams);

            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    break;
            }
        }
    }
}
