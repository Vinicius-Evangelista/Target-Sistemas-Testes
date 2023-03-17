#include <iostream>
#include <string>

int main()
{

    std::string str {"Target Sistemas"};

    for (int index {str.length() - 1}; index >= 0; index--) {
        std::cout << str[index];
    }

    std::cout << "\n" << "Press ENTER to exit..." << std::endl;

    std::string a;
    std::getline(std::cin, a);

    return 0;
}