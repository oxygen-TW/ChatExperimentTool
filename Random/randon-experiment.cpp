#include <iostream>
#include <random>
#include <fstream>
#include <vector>
#include <algorithm>

#define people 40
using namespace std;

int main()
{
    vector<int> seat = {};

    for(int i=0;i<people;i++)
        seat.push_back(i + 1);

    //建立隨機設備
    random_device rd;

    //亂數產生器(梅森旋轉演算法)
    mt19937 generator(rd());

    shuffle(seat.begin(),seat.end(),generator);

    fstream fp;
    fp.open("Seat.txt",ios::out);
    fp<<"ID,Seat"<<endl;

    for(int i=0;i<people;i++){
        fp<<i+1<<","<<seat[i]<<endl;
    }

    fp.close();
    cout<<"Finished!"<<endl;
}
