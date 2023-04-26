// setting up.
#include <iostream>
#include <string>

// declaring the function.
int main()
{
    // saying welcome.
    std::cout << "Welcome to Rouge-Protocol_credits to start the credits please enter 'start credits'\n";
    // declaring the 'input' function.
    int input(); {

        // the input itself.
        std::cout << "> ";
        std::string Command;
        std::cin >> Command;
        std::cout << Command;
        // printing the credits.
        if (Command == "credits") {
            std::cout << "Thank you for playing. This was a video game by Asah Curtis.\n insparation from games such a bitrunner.\n Again thank you for playing, I hope I make more games and I hope you play them. ";
        // this is where invalid inputs are rejected.
        }
        else {
            std::cout << "Invalid input, please input credits.";
            input();
        }
    }
    // returning the code.
    return 0;
}

