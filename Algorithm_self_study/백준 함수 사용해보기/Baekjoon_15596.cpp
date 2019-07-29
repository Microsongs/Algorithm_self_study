#include <vector>
#include <iostream>
#include <time.h>

#define MAX 1000000

long long sum(std::vector<int>& a) {
	long long ans = 0;
	for (int i = 0; i < a.size(); i++) {
		ans += a[i];
	}
	/*
	// 이터레이터 사용, 백준에서 컴파일에러(vs실행O)
	for (std::vector<int>::iterator i = a.begin(); i != a.end(); i++) {
		ans += (*i);
	}
	*/
	/*
	// foreach 사용, 백준에서 컴파일에러(vs실행O)
	for (auto i : a) {
		ans += i;
	}
	*/
	return ans;
}

int main() {
	using namespace std;
	srand((unsigned int)time(NULL));
	vector<int> arr;
	for (int i = 0; i < MAX; i++) {
		// 문제의 범위 : 1~3000000
		arr.push_back((rand() % 3000000) + 1);
	}
	cout << sum(arr) << endl;
}