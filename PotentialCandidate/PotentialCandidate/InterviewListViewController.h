//
//  InterviewListViewController.h
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/22/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import <UIKit/UIKit.h>
@class Candidate;
@protocol InterviewListViewControllerDelegate<NSObject>
@optional
- (void)candidateSeleted:(Candidate *)cadidate;
@end
@interface InterviewListViewController : UIViewController
@property (nonatomic, assign) id<InterviewListViewControllerDelegate> delegate;
@end
