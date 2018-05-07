// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UnwindSegue/UnwindSegue.h>
#import <UIKit/UIKit.h>

#import "BaseViewController.h"

@interface ThirdViewController : BaseViewController {
	UISwitch *_switchUnwind;
}

@property (nonatomic, retain) IBOutlet UISwitch *switchUnwind;

- (IBAction)prepareForUnwind:(UIStoryboardSegue *)segue;

- (IBAction)btnDoUnwind:(id)sender;

- (IBAction)btnGoToFirst:(id)sender;

- (IBAction)btnShowModal:(id)sender;

@end
