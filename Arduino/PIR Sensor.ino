int ledPin1 = 11;                
int inputPin1 = 2;               
int pirState1 = LOW;             
int val1 = LOW;                    

int ledPin2 = 12;
int inputPin2 = 4;               
int pirState2 = LOW;             
int val2 = LOW;

int ledPin3 = 13;
int inputPin3 = 7;               
int pirState3 = LOW;             
int val3 = LOW;

void setup() {
  pinMode(ledPin1, OUTPUT);     
  pinMode(ledPin2, OUTPUT);
  pinMode(ledPin3, OUTPUT);
  pinMode(inputPin1, INPUT);    
  pinMode(inputPin2, INPUT);
  pinMode(inputPin3, INPUT);
  Serial.begin(9600);
}
 
void loop(){
  //Senzor 1
  digitalWrite(ledPin1, LOW);
  val1 = digitalRead(inputPin1);  
  if (val1 == HIGH) {      
    digitalWrite(ledPin1, HIGH);  
    if (pirState1 == LOW) {
      Serial.println("S-a detectat o miscare in DORMITOR!"); 
      delay(1000);
      pirState1 = HIGH;
    }
  } else {
    digitalWrite(ledPin1, LOW); 
    if (pirState1 == HIGH){
      Serial.println("Miscarea a incetat in DORMITOR!"); 
      delay(1000);
      pirState1 = LOW;
    }
  }
  //Senzor 2
  digitalWrite(ledPin2, LOW);
  val2 = digitalRead(inputPin2);  
  if (val2 == HIGH) {      
    digitalWrite(ledPin2, HIGH);  
    if (pirState2 == LOW) {
      Serial.println("S-a detectat o miscare in SUFRAGERIE!"); 
      delay(1000);
      pirState2 = HIGH;
    }
  } else {
    digitalWrite(ledPin2, LOW); 
    if (pirState2 == HIGH){
      Serial.println("Miscarea a incetat in SUFRAGERIE!"); 
      delay(1000);
      pirState2 = LOW;
    }
  }
  //Senzor 3
  digitalWrite(ledPin1, LOW);
  val3 = digitalRead(inputPin3);  
  if (val3 == HIGH) {      
    digitalWrite(ledPin3, HIGH);  
    if (pirState3 == LOW) {
      Serial.println("S-a detectat o miscare in BUCATARIE!"); 
      delay(1000);
      pirState3 = HIGH;
    }
  } else {
    digitalWrite(ledPin3, LOW); 
    if (pirState3 == HIGH){
      Serial.println("Miscarea a incetat in BUCATARIE!"); 
      delay(1000);
      pirState3 = LOW;
    }
  }
}
