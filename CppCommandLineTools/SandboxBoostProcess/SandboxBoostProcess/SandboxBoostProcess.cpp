// SandboxBoostProcess.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <boost\process.hpp>
#include <string>
#include <boost\filesystem\path.hpp>
namespace bp = boost::process;

void RunProcessBoost() {
    bp::ipstream pipe_stream;
    std::string command = R"(explorer D:\temp)";
    bp::child c(command.c_str(), bp::std_out > stdout);

    std::string line;

    while (std::getline(pipe_stream, line) && !line.empty())
        std::cerr << line << std::endl;

    c.wait();
}

int main()
{
    std::cout << "Hello World!\n";
    RunProcessBoost();
}


