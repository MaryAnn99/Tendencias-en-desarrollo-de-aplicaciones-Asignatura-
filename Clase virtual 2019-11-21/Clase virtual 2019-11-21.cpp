#include<bits/stdc++.h>

using namespace std;
const int iNF = 1e9 + 100;

/*
Pascal case
Camel case
Lower case
Upper case
Snake case
Pack
LTrim
RTrim
Trim
*/

string Pascal(string s){
   int l = s.length();
   int p1 = 0;
   while(p1 < l){
      while(p1 < l and s[p1] == ' '){
         p1 ++;
      }
      if(p1 >= l){
         break;
      }
      s[p1] = toupper(s[p1]);
      while(p1 < l and s[p1] != ' '){
         p1 ++;
      }
   }
   return s;
}

string Camel(string s){
   s = Pascal(s);
   int l = s.length();
   for(int i = 0; i < l; i++){
      if(s[i] != ' '){
         s[i] = tolower(s[i]);
         break;
      }
   }
   return s;
}

string Lower(string s){
   transform(s.begin(), s.end(), s.begin(), ::tolower);
   return s;
}

string Upper(string s){
   transform(s.begin(), s.end(), s.begin(), ::toupper);
   return s;
}

string Snake(string s){
   int l = s.length();
   int start = 0, end = 0;
   for(int i = 0; i < l; i++){
      if(s[i] != ' '){
         start = i;
         break;
      }
   }
   for(int i = l - 1; i >= 0; i--){
      if(s[i] != ' '){
         end = i;
         break;
      }
   }
   for(int p1 = start; p1 <= end; p1++){
      if(s[p1] == ' '){
         s[p1] = '_';
      }
   }
   return s;
}

string Pack(string s){
   int l = s.length();
   int start = 0;
   string answer = "";
   for(int i = 0; i < l; i++){
      if(s[i] != ' '){
         start = i;
         break;
      }
      answer += s[i];
   }
   int end = l;
   for(int i = start; i < l ; i++){
      if(s[i] != ' '){
         answer += s[i];
         end = i;
      }
   }
   for(int i = l - 1; i > end; i--){
      if(s[i] != ' '){
         break;
      }
      answer += s[i];
   }
   return answer;
}

string LTrim(string s){
   int l = s.length();
   int start = -1;
   for(int i = 0; i < l; i++){
      if(s[i] != ' '){
         start = i;
         break;
      }
   }
   if(start == -1){
      return s;
   }else{
      return s.substr(start, l - start);
   }
}

string RTrim(string s){
   int l = s.length();
   int end = -1;
   for(int i = l - 1; i >= 0; i--){
      if(s[i] != ' '){
         end = i;
         break;
      }
   }
   if(end == -1){
      return s;
   }else{
      return s.substr(0, end + 1);
   }
}

string Trim(string s){
   s = LTrim(s);
   s = RTrim(s);
   return s;
}

string funcA(string command, string s){
   if(command == "Pascal"){
      return Pascal(s);
   }
   if(command == "Camel"){
      return Camel(s);
   }
   if(command == "Lower"){
      return Lower(s);
   }
   if(command == "Upper"){
      return Upper(s);
   }
   if(command == "Snake"){
      return Snake(s);
   }
   if(command == "Pack"){
      return Pack(s);
   }
   if(command == "LTrim"){
      return LTrim(s);
   }
   if(command == "RTrim"){
      return RTrim(s);
   }
   if(command == "Trim"){
      return Trim(s);
   }
   return s;
}

int funcB(string s, string s_model, vector<string> &a){
   int iterations = pow(2, a.size());
   int best = iNF, ans = 0;
   // start 0, it must have a least 1
   for(int i = 1; i <= iterations - 1; i++){
      int stop = ( log(i)/log(2) ) + 1;
      string s1 = s;
      int cnt = 0;
      for(int j = 0; j <= stop; j++){ 
         if((i & (1<<j))!=0){
              //take it
              cnt ++;
              s1 = funcA(a[j], s1);
         }
      }
      if(s1 == s_model and cnt < best){
         //valid answer
         best = cnt;
         ans = i;
      }
   }
   return ans;
}

int main(){
   string s;
   getline(cin, s);
   //“Upper->Lower->Upper”
   int n = s.length();
   vector<string> a;
   int p1 = 0;
   for(int i = 0; i < n - 1; i++){
      if(s[i] == '-' and s[i + 1] == '>'){
         a.push_back(s.substr(p1, i - p1)); // + 1 - 1
         i ++;
         p1 = i + 1;
      }
   }
   a.push_back(s.substr(p1, n - p1)); //last word
   string sample = " Aa aaBb ", s_model;
   s_model = sample;
   int sz = a.size();
   for(int i = 0; i < sz; i++){
      s_model = funcA(a[i], s_model);
   }
   int ans = funcB(sample, s_model, a);
   int stop = ( log(ans)/log(2) ) + 1;
   string answer = "";
   for(int j = 0; j <= stop; j++){ 
      if((ans & (1<<j))!=0){
           answer += a[j] + "->";
      }
   }
   cout << endl << s << " === " << answer.substr(0, answer.length() - 2) << endl;
   return 0;
}
