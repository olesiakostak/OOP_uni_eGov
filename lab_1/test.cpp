#include <iostream>
#include <vector>
#include <cmath>
#include <algorithm>
using namespace std;

int main()
{
    int x, y;
    cin >> x >> y;
    int n, k;
    cin >> n >> k;
    vector<long double> dis(n);
    
    for (int i = 0; i < n; i++)
    {
        int n_1, n_2;
        cin >> n_1 >> n_2;
        dis[i] = sqrt(pow(n_1, 2) + pow(n_2, 2));
    }
    sort(dis.begin(), dis.end());
    cout << dis[k - 1];
    
    return 0;
}