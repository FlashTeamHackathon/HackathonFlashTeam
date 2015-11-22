//
//  InterViewDetailsViewController.h
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/22/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import "DetailsViewController.h"
@protocol InterViewDetailsViewControllerDelegate<NSObject>
@optional
- (void)updateInterview:(Candidate *)candidate;
@end
@interface InterViewDetailsViewController : DetailsViewController
@property (nonatomic, assign) id<InterViewDetailsViewControllerDelegate> delegate;
@end
