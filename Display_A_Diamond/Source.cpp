#include <iostream>
using namespace std;
int main() {
	int holesRangeleft = 14;
	int holeRangeRight = 14;
	for (int i = 0; i < 31; i++) {
		cout<<" ";
		for (int j = 0; j < 30; j++){
			cout<<((j > holesRangeleft&& j < holeRangeRight)? "*" : " ");
		}
		i <= 14 ? holeRangeRight++ : holeRangeRight--;
		i <= 14 ? holesRangeleft-- : holesRangeleft++;
		cout << "\n";
	}
	return 0;
}