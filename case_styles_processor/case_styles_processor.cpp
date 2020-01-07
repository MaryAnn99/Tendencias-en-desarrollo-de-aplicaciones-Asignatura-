#include <iostream>
#include <vector>
#include <string>
using namespace std;

// operation is a natural[1, 9]
// 1 is Trim
// 2 is LTrim
// 3 is RTrim
// 4 is Upper
// 5 is Lower
// 6 is Pack
// 7 is Snake
// 8 is Pascal
// 9 is Camel

// Snake = lower + _ in between_word_spaces(snake)
// Pascal = PacalCase = Pack + lower + upper_ALL_firsts(pascal)
// Camel =  camelCase = Pack + lower + pascal + lower_first_letter(camel)

char to_lower_func(char c){
   if(c >= 'A' and c <= 'Z'){
      return (c + ('a' - 'A'));
   }
   return c;
}

char to_upper_func(char c){
   if(c >= 'a' and c <= 'z'){
      return (c - ('a' - 'A'));
   }
   return c;
}

string case_styles_processor(string word, string &operations){
	string res = "";
	//block 1...
	int operations_length = operations.length();
	string operation = "";
	vector<int> a;
	for(int i = 0; i <= operations_length; i++){
		if(operations[i] == '-' or i == operations_length){
			if(operation == "Trim"){
				a.push_back(1);
			}else if(operation == "LTrim"){
				a.push_back(2);
			}else if(operation == "RTrim"){
				a.push_back(3);
			}else if(operation == "Upper"){
			   a.push_back(4);
			}else if(operation == "Lower"){
			   a.push_back(5);
			}else if(operation == "Pack"){
			   a.push_back(6);
			}else if(operation == "Snake"){
			   a.push_back(7);
			}else if(operation == "Pascal"){
			   a.push_back(8);
			}else if(operation == "Camel"){
			   a.push_back(9);
			}else{
				return "Error: not defined operation";
			}
			if(i == operations_length){ break; }
			operation = "";
			continue;
		}
		operation += operations[i];
	}
	
	//block 2...
	int number_operations = a.size();
	bool trim = false, l_trim = false, r_trim = false;
	bool upper = false, lower = false;
	bool pack = false, snake = false;
	bool pascal = false, pascal_first = false;
	bool camel = false;
	for(int i = 0; i < number_operations; i++){
		switch(a[i]){
			case 1: //Trim
				trim = true;
				l_trim = false;
				r_trim = false;
			break;
			
			case 2: //LTrim
				if(!trim){
					l_trim = true;
				}
			break;
			
			case 3: //RTrim
				if(!trim){
					r_trim = true;
				}
			break;
         
         case 4: //Upper
				upper = true;
				lower = false;
				camel = false;
				//as pacal is upper, nothing change
			break;
			
			case 5: //Lower
				lower = true;
				upper = false;
				pascal = false; //pascal is upper, if there is lower then its not upper anymore
				pascal_first = false;
			break;
			
			case 6: //Pack
			   if(!snake){
			      pack = true;
			   }
			break;
			
			case 7: //Snake
			   if(!pack){
			      snake = true;
			   }
			   lower = true;
			   upper = false;
			   pascal = false;
			   pascal_first = false;
			break;
			
			case 8: //Pascal
			   if(snake or pack){
			      pascal_first = true;
			   }else{
   			   pack = true;
   			   pascal = true;
			   }
			   lower = true;
   			upper = false;
   			camel = false;
			break;
			
			case 9: //Camel
			   if(!snake and !pack){
   			   pack = true;
   			   pascal = true;
			   }
			   camel = true;
			   lower = true;
   			upper = false;
			break;
         
			default:
				return "Error: not defined operation";
		}
	}
	
	//block 3...
	//finite-state machine (FSM)
	bool outside_word_start = true;
	bool outside_word_end = false;
	bool inside_word = false; //first letter moment
	bool first_letter = false;
	bool between_words = false; // -> not inside a word and not outside..
	bool first_letter_word = false; //first letter of the word string
	int word_length = word.length();
	int last_char_pos = word_length;
	
	//identify outside_word_end
	//two ways:
	//	1. keeping on the possible ends
	//	2. precompute the last char position (choosed)
	for(int i = word_length - 1; i >= 0; i--){
		if(word[i] != ' '){
			last_char_pos = i + 1;
			break;
		}
	}
	
	for(int i = 0; i < word_length; i++){
	   if(first_letter){
	      first_letter = false;
	      first_letter_word = false;
	   }
		//transition
		if(word[i] != ' ' and !inside_word){
		   if(outside_word_start){
		      first_letter_word = true;
		      outside_word_start = false;
		   }
			inside_word = true;
			first_letter = true;
			between_words = false;
		}
		if(i == last_char_pos){
			outside_word_end = true;
			inside_word = false;
		}
		//this goes after, essential  !!!
		if(inside_word and word[i] == ' '){
		   between_words = true;
		   inside_word = false;
		}
		
		if(outside_word_start){
			if(trim or l_trim){
				continue;
			}
		}
		if(outside_word_end){
			if(trim or r_trim){
				continue;
			}
		}
		if(inside_word){
		   res += word[i];
		   if(upper){
		      res[res.length() - 1] =  to_upper_func(res[res.length() - 1]);
		   }else if(lower){ //this works for snake case too...
		      res[res.length() - 1] =  to_lower_func(res[res.length() - 1]);
		   }
		   //this goes after, essential  !!!
		   if(first_letter){
		      if(pascal){
		         res[res.length() - 1] =  to_upper_func(res[res.length() - 1]);
		      }
		       //this goes after, essential  !!!
		      if(first_letter_word){
		         if(pascal_first){
		            res[res.length() - 1] =  to_upper_func(res[res.length() - 1]);  
		         }
		         if(camel){
		            res[res.length() - 1] =  to_lower_func(res[res.length() - 1]);  
		         }
		      }
		   }
		   continue;
		}
		if(between_words){
		   if(pack){
		      continue;
		   }
		   if(snake){
		      res += '_';
		      continue;
		   }
		}
		res += word[i];
	}
	return res;
}


int main(){
	string word = "Hello WOrLd";
	string operations = "Upper-Snake";
	cout << "Example: " << endl;
	cout << word << endl;
	cout << operations << endl;
	cout << "output: " << case_styles_processor(word, operations) << endl;
	while(true){
		cout << endl << "Input: word \\n operations " << endl;
		getline(cin, word);
		getline(cin, operations);
		cout << case_styles_processor(word, operations) << endl;
	}
	return 0;
}
