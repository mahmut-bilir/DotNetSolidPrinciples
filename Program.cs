
EmailService emailService = new EmailService();
UserService userService = new UserService(emailService);
userService.CreateUser("user1", "user1@hotmail.com");
