#include <DigiUSB.h>

#define clk 0
#define input 1

int inByte = 0;
int sendTO;
int previousState = LOW;

void setup() {
  // put your setup code here, to run once:
  pinMode(input, INPUT);
  pinMode(clk, INPUT);
  DigiUSB.begin();
  DigiUSB.println("USB is ready");
}

void loop() {

  inByte = digitalRead(clk);
  if(DigiUSB.available())  // this is to check is there any signal from USB
  {
    if(previousState == LOW && inByte == HIGH)
    {
      digitalWrite(1,HIGH);
      sendTO = digitalRead(input);
      DigiUSB.println(sendTO);
     }
  }
  previousState = inByte;
  DigiUSB.delay(10);
}




