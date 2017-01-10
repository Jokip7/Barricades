using Barricades.View;

namespace Barricades.Controller
{
    class MainController
    {
        private InputView inputView { get; set; }

        private OutputView outputView { get; set; }
        
        private GameController gameController { get; set; }

        public MainController()
        {
            inputView = new InputView();
            outputView = new OutputView();
            gameController = new GameController();
        }

        public void startApplication()
        {
            outputView.printWelcome();
            gameController.startGame();
        }

        public void handleInput()
        {
            var input = inputView.getInput();

            switch (input.KeyChar)
            {
                default:
                    outputView.printInputError();
                    break;
            }
        }
    }
}
