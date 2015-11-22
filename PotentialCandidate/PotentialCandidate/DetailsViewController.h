//
//  DetailsViewController.h
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/21/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import <UIKit/UIKit.h>
@class Candidate;
@interface DetailsViewController : UIViewController
{
    
}
@property (weak, nonatomic) IBOutlet UIImageView *imvAvartar;
@property (weak, nonatomic) IBOutlet UILabel *lblFullName;
@property (weak, nonatomic) IBOutlet UILabel *lblPhoneNumber;
@property (weak, nonatomic) IBOutlet UILabel *lblAddress;
@property (weak, nonatomic) IBOutlet UILabel *lblExpreience;
@property (weak, nonatomic) IBOutlet UILabel *lblMajor;
@property (weak, nonatomic) IBOutlet UILabel *lblJobTitle;
@property (weak, nonatomic) IBOutlet UILabel *lblSchool;
@property (weak, nonatomic) IBOutlet UISlider *siderScore;
@property (weak, nonatomic) IBOutlet UISlider *siderScoreActure;
@property (weak, nonatomic) IBOutlet UILabel *lblScore;
@property (weak, nonatomic) IBOutlet UILabel *lblActualScore;
@property (weak, nonatomic) IBOutlet UIButton *btnBookInterview;
@property (nonatomic,strong) Candidate *candidateSeletedVaule;
- (void)candidateSeleted:(Candidate *)cadidate;
@end
