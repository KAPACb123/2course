//#include <iostream>
//using namespace std;
/*
void hanoi(int start, int finish, int n)
{
    if (n == 1) {
        cout << "peremestim tarelku 1 s palki " << start << " na palku" << finish << endl;
    }
    else {
        int tmp = 6 - start - finish;
        hanoi(start, tmp, n - 1);
        cout << "peremestim tarelku " << n << " s palki " << start << " na palku " << finish << endl;
        hanoi(tmp, finish, n - 1);
    }
}
*/
#include <iostream>
#include <queue>
#include <vector>


#define INF INT_MAX

using namespace std;

void dijkstra(vector<vector<int>> G) {
    int n = G[0].size();
    queue <int> Q;
    int dist[n];
    bool visited[n];
    dist[0] = 0;
    visited[0] = true;
    for (int i = 1; i < n; i++) {
        dist[i] = INF;
        visited[i] = false;
    }
    Q.push(v:0);
    while (!Q.empty()) {
        int current = Q.front();
        Q.pop();
        visited[current] = true;
        for (int j = 0; j < G[current].size(); j++) {
            if (
                !visited[j] && G[current][j] != 0 && dist[current] + G[current][j] < dist[j]
                )
            {
                dist[j] = dist[current] + G[current][j];
                Q.push(j);
            }
        }
    }
    for (int i = 0; i < n; i++) {
        cout << dist[i] << " ";
    }
    return;
}

int main() {
    int n;
    cin >> n;
    vector<vector<int>>G(n, x:vector<int>(n, x:0));
    int x, y, d;
    for (int i = 0; i < n; i++) {//заполнение матрицы смежности
        cin >> x >> y >> d;
        G[x][y] = d;
        G[y][x] = d;
    }
    dijkstra(G);
}