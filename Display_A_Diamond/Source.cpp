#include <iostream>
using namespace std;
int main() {
	char fillWith = '^';
	int Hlength = 106;
	(Hlength % 2) ? Hlength++ : Hlength;
	int Vlength = Hlength;
	int holesRangeleft = Vlength/2;
	int holeRangeRight = holesRangeleft;
	for (int i = 0; i < Vlength+2; i++) {
		cout<<" ";
		for (int j = 0; j < Hlength+1; j++){
			cout<<((j > holesRangeleft&& j < holeRangeRight)? fillWith : ' ');
		}
		i <= Vlength / 2 ? holeRangeRight++ : holeRangeRight--;
		i <= Vlength / 2 ? holesRangeleft-- : holesRangeleft++;
		cout << "\n";
	}
	return 0;
}