#include <iostream>
#include <random>
#include <fstream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    vector<int> seat = {};

    for(int i=0;i<100;i++)
        seat.push_back(i + 1);

    //�إ��H���]��
    random_device rd;

    //�üƲ��;�(���˱���t��k)
    mt19937 generator(rd());

    shuffle(seat.begin(),seat.end(),generator);

    fstream fp;
    fp.open("Seat.txt",ios::out);
    fp<<"ID,Seat"<<endl;

    for(int i=0;i<100;i++){
        fp<<i+1<<","<<seat[i]<<endl;
    }

    fp.close();
    cout<<"Finished!"<<endl;
}
