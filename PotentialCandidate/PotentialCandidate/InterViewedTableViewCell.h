//
//  InterViewedTableViewCell.h
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/22/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "CadidateTableViewCell.h"
@interface InterViewedTableViewCell : CadidateTableViewCell
{
    
}
@property (weak, nonatomic) IBOutlet UIView *uivtualScore;
@property (weak, nonatomic) IBOutlet UILabel *lblActual;

@end
