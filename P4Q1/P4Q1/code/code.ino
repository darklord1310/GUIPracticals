#include <DigiUSB.h>

#define led0 0
#define led1 1
#define led2 2

int inByte;

void setup() {
  // put your setup code here, to run once:
  pinMode(2, OUTPUT);
  pinMode(1, OUTPUT);
  pinMode(0, OUTPUT);
  DigiUSB.begin();
  DigiUSB.println("USB is ready");
}

void loop() {

  if(DigiUSB.available())  // this is to check is there any signal from USB
  {
    inByte = DigiUSB.read();  // read the byte

    if(inByte == 255)
    {
      digitalWrite(led0, LOW);
      digitalWrite(led1, LOW);
      digitalWrite(led2, LOW);
    }
    else
    {
      if(inByte == 0)
      {
        digitalWrite(led0, HIGH);
        DigiUSB.println("H");
      }

      if(inByte == 1)
      {
        digitalWrite(led1, HIGH);
        DigiUSB.println("H");
      }

      if(inByte == 2)
      {
        digitalWrite(led2, HIGH);
        DigiUSB.println("H");
      }
    }
  }
  
  DigiUSB.delay(100);
}
