//
//  CadidatesViewController.h
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/21/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "Candidate.h"
@protocol CadidatesViewControllerDelegate<NSObject>
@optional
- (void)candidateSeleted:(Candidate *)cadidate;
@end
@interface CadidatesViewController : UIViewController
@property (nonatomic, assign) id<CadidatesViewControllerDelegate> delegate;
@property (nonatomic,strong) NSMutableArray *arrApplied;
@property (nonatomic,strong) NSMutableArray *arrPotential;
@end
