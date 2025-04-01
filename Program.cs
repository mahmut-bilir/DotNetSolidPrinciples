
EmailService emailService = new EmailService();
UserService userService = new UserService(emailService);
userService.CreateUser("user1", "user1@hotmail.com");

IPayment creditCart = new CreditCardPayment();
IPayment payPal = new PayPalPayment();
PaymentServices cc = new PaymentServices();
cc.Pay(creditCart);
cc.Pay(payPal);


IDevice lightBulb = new LightBulb();
Switch _switch = new Switch(lightBulb);
_switch.Press();