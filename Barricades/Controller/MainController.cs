using Barricades.Model;
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
        }

        public void startApplication()
        {
            gameController = new GameController(inputView, outputView);
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
