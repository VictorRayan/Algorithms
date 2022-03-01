#include <iostream>
using namespace std;

/*string unit[] = {"unit1_", "unit2_ ", "unit3_"};
string tens[] = {"tens1_", "tens_2", "tens_3"};
*/

string first_values[] = {"met", "et", "prop", "but", "pent", "hex", "hept", "oct",
                        "non", "dec", "undec", "dodec", "tridec", "tetradec", "pentadec", "hexadec",
                        "heptadec", "octadec", "nonadec"};

string unit[]= {"hen", "do", "tri", "tetra", "penta", "hexa", "hepta", "octa", "nona"};
string tens[]= {"cos", "triacont", "tetracont", "pentacont", "hexacont", "heptacont", "octacont", "nonacont"};

int u_len = sizeof(unit)/sizeof(*unit);
int t_len = sizeof(unit)/sizeof(*unit);
int f_len = sizeof(first_values)/sizeof(*first_values);


void print_excp(int u_index, int t_index, bool use_u){

        if(t_index == 0 && use_u==false){
                cout << "ei";
        }else if(t_index == 0 && use_u==true){
                cout << unit[u_index] << "ei";
        }
}



int main(){


        //Prints the first 19 non-standard values:
        cout << "Non-standard values: \n";
        for(int i=0; i < f_len; i++){
                cout << "["<< i <<"]:  " << first_values[i] <<"\n";
        }


        cout << "\n\n"<<"Standardized values: \n";
        int j=0;
        int index=20;
        for(int z=0; z < t_len - 1; z++){

                cout << "\n" << "[" << index << "]:  ";
                print_excp(0,j, false);
                cout << tens[j]<<"\n";

                for(int i=0; i < t_len; i++){
                                cout << "["<<(index+1)<<"]:  ";

                                if(i==0){
                                        print_excp(i, j, true);
                                }else{
                                        cout << unit[i];
                                }
				
				string str_index =  to_string(index+1);
				if(str_index.substr(1,1)=="1" && (index+1)!=21){
					cout << unit[i];
				}
				
                                cout << tens[j] << "\n";
                                index++;


                }

                j++;
                index++;

        }

        cout << "[100]:  "<< "hect" <<"\n";
        cout << "[101]:  "<< "nenect"<<"\n";

}
